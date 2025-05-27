using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Aida.Sdk.Mini.Model;
using Microsoft.Extensions.Logging;

namespace Aida.Samples.Integration.UI.Forms
{
    public partial class InsertDataForm : Form
    {
        private ILogger _logger;

        private Dictionary<string, byte[]> _imageCache = new();

        List<EntityDescriptor> _entities;

        public InsertDataForm(ILogger<InsertDataForm> logger)
        {
            _logger = logger;
            InitializeComponent();
        }

        public InsertDataForm Initialize(List<EntityDescriptor> entities)
        {
            AddFields(entities);
            _entities = entities;
            return this;
        }

        private void AddFields(List<EntityDescriptor> entities)
        {
            foreach (var e in entities)
            {
                flowLayoutPanel.Controls.Add(new Label() { Text = e.DisplayName });

                Control data;

                if (e.ValueType == EntityFieldValueType.String)
                {
                    data = new TextBox { Text = e.DisplayName, Name = $"Txt{e.DisplayName}", Width = 250 };
                }
                else
                {
                    data = new PictureBox
                    {
                        Name = $"Img{e.DisplayName}",
                        SizeMode = PictureBoxSizeMode.Zoom,
                        BorderStyle = BorderStyle.FixedSingle,
                        MaximumSize = new Size(150, 150),
                        //Image = Resources.ixla_black_logo
                    };

                    var entityName = e.DisplayName;

                    data.Click += new EventHandler(delegate(object sender, EventArgs e)
                    {
                        var fd = new OpenFileDialog() { Title = "Choose Image" };
                        if (fd.ShowDialog() == DialogResult.OK)
                        {
                            _imageCache[entityName] = File.ReadAllBytes(fd.FileName);
                            ((PictureBox)sender).Image = Image.FromStream(new MemoryStream(_imageCache[entityName]));
                        }
                    });
                }

                flowLayoutPanel.SetFlowBreak(data, true);
                flowLayoutPanel.Controls.Add(data);
            }
        }

        public PersonalizationRecord Record { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertRecord(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertRecord(true);
        }

        private void InsertRecord(bool continueInsert)
        {
            Record = new PersonalizationRecord();
            var fields = new List<PersonalizationField>();

            foreach (var entity in _entities)
            {
                if (entity.ValueType == EntityFieldValueType.String)
                {
                    var ctrl = flowLayoutPanel.Controls.Find($"Txt{entity.DisplayName}", false)[0];
                    fields.Add(new PersonalizationField(entity.EntityName, ((TextBox)ctrl).Text));
                }
                else
                {
                    var ctrl = flowLayoutPanel.Controls.Find($"Img{entity.DisplayName}", false)[0];
                    var img = ((PictureBox)ctrl).Image;
                    if (img != null) fields.Add(new PersonalizationField(entity.EntityName, _imageCache[entity.DisplayName]));
                }
            }

            Record.Fields = fields;

            DialogResult = continueInsert ? DialogResult.Retry : DialogResult.OK;
            Close();
        }
    }
}