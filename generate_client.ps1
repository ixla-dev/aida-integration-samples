<# 
  .PARAMETER OutputDir
  The output directory that will contain the generated solution 

  .PARAMETER GeneratorConfigFilePath 
  The path of a JSON file containing the configuration for the openapi-generator-cli csharp-netcore generator. For a comprehensive list of
  parameters see https://openapi-generator.tech/docs/generators/csharp-netcore/

  .PARAMETER OpenApiSpecUri 
  The URL or file path of an open-api specification. 

  .DESCRIPTION  
  Generate the HTTP Client SDK for IXLA.AIDA systems
#>
param(
    [string] $OutputDir = [System.IO.Path]::GetFullPath([System.IO.Path]::Combine($PSScriptRoot, "Aida.Sdk.Mini")),
    [string] $GeneratorConfigFilePath = [System.IO.Path]::GetFullPath([System.IO.Path]::Combine($PSScriptRoot, "csharp-generator-config.json")),
    [string] $OpenApiSpecUri = "http://192.168.24.101:5000/aida-mini/v1/swagger.json",
    [string] $GitUserId = "-",
    [string] $GitRepoId = "-"
)

Write-Host "
    OutputDir:
    $OutputDir

    Generator config file:
    $GeneratorConfigFilePath
    
    Open API Spec URI:
    $OpenApiSpecUri
"

# empty the output directory
if (Test-Path $OutputDir)
{
    rm -Recurse -Force -Path $OutputDir
}
else 
{
    mkdir $OutputDir
}

# fail immediately if the config file does not exists
if ($(Test-Path $GeneratorConfigFilePath) -eq $false) 
{
    Write-Error "The specified generator config file '$GeneratorConfigFilePath' does not exists" 
    Exit 1;
}

# read the generator options to compute the correct output dir for the generated project
$configContents   = Get-Content -Raw $GeneratorConfigFilePath | ConvertFrom-Json
$outputProjectDir = [System.IO.Path]::Combine($OutputDir, $configContents.sourceFolder, $configContents.PackageName)
Write-Host "
    Output Project Dir: 
    $outputProjectDir
";


if ($OpenApiSpecUri -Match '^http')
{
    try {
        Write-Host "Fetching $OpenApiSpecUri"
        $response = Invoke-WebRequest -Uri $OpenApiSpecUri -Method Get -TimeoutSec 3
        $specificationContent = $response.Content | ConvertFrom-Json
    } catch {
        Write-Error "Failed to fetch open api specification from $OpenApiSpecUri"
        Exit 1;
    }
} else 
{
    $specificationContent = Get-Content -Raw $OpenApiSpecUri | ConvertFrom-Json
}


# set the assembly version for the generated SDK equal to the server version
$serverVersion = $specificationContent.info.version;
Write-Host "openapi-generator-cli generate -o $OutputDir -g csharp-netcore -c $GeneratorConfigFilePath -i $OpenApiSpecUri --git-user-id=$GitUserId --git-repo-id=$GitRepoId --additional-properties=packageVersion=$serverVersion" 
openapi-generator-cli generate -o $OutputDir -g csharp-netcore -c $GeneratorConfigFilePath -i $OpenApiSpecUri --git-user-id=$GitUserId --git-repo-id=$GitRepoId --additional-properties="packageVersion=$serverVersion"

# if the outputProject dir does not exists something went wrong with openapi-generator
if ($(Test-Path $outputProjectDir) -eq $false) 
{
    Write-Error "Client generation failed." 
    Exit 1;
}  

pushd $outputProjectDir
    # build the SDK to make sure we have a working project
    dotnet build -c Release
popd


