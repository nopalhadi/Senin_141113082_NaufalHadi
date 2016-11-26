﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace Latihan4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public bool simp = true;
        public string filelocation = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            InstalledFontCollection ftFamily = new InstalledFontCollection();
            foreach (FontFamily i in ftFamily.Families)
            {
                tsFont.Items.Add(i.Name);
            }
            tsFont.SelectedIndex = 12;
            for (int i = 5; i <= 72; i++)
            {
                tsSize.Items.Add(i);
            }
            tsSize.SelectedIndex = 12;
            tsFont.ComboBox.LostFocus += new EventHandler(tsFont_LostFocus);
            tsSize.ComboBox.LostFocus += new EventHandler(tsFont_LostFocus);
            tsFont.ComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            tsFont.ComboBox.DrawItem += new DrawItemEventHandler(tsFont_DrawItem);

            foreach (PropertyInfo property in typeof(Color).GetProperties())
            {
                if (property.PropertyType == typeof(Color))
                    tsColor.Items.Add(property.Name);
            }
            tsColor.SelectedIndex = 8;
            tsColor.ComboBox.LostFocus += new EventHandler(tsFont_LostFocus);
            tsColor.ComboBox.DrawItem += new DrawItemEventHandler(tsColor_DrawItem);
            tsColor.ComboBox.DrawMode = DrawMode.OwnerDrawFixed;

            change();

        }
        private void tsFont_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.Graphics.DrawString(tsFont.Items[e.Index].ToString(), new Font(tsFont.Items[e.Index].ToString(), tsFont.Font.Size), Brushes.Black, e.Bounds);

        }
        private void tsColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                Graphics grap = e.Graphics;
                Brush brush = new SolidBrush(e.BackColor);
                Brush fbrush = new SolidBrush(e.ForeColor);
                grap.FillRectangle(brush, e.Bounds);
                string s = (string)this.tsColor.Items[e.Index].ToString();
                SolidBrush b = new SolidBrush(Color.FromName(s));
                e.Graphics.DrawRectangle(Pens.Black, 2, e.Bounds.Top + 1, 20, 11);
                e.Graphics.FillRectangle(b, 3, e.Bounds.Top + 2, 19, 10);
                e.Graphics.DrawString(s, this.Font, Brushes.Black, 25, e.Bounds.Top);
                brush.Dispose();
                fbrush.Dispose();
            }
            e.DrawFocusRectangle();
        }

        private void tsFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox ts = (ToolStripComboBox)sender;
            if (!ts.Focused)
                return;
            change();
        }
        public void change()
        {
            float fsize;
            if (tsSize.Text == "")
                fsize = 12;
            else
            {
                fsize = (float)Convert.ToDouble(tsSize.SelectedItem);
                FontStyle style = (tsBold.Checked) ? FontStyle.Bold : FontStyle.Regular;
                style |= (tsItalic.Checked) ? FontStyle.Italic : FontStyle.Regular;
                style |= (tsUnd.Checked) ? FontStyle.Underline : FontStyle.Regular;
                Font baru = new Font(tsFont.SelectedItem.ToString(), fsize, style);
                editor.SelectionFont = baru;
                editor.SelectionColor = Color.FromName(tsColor.Text);
                editor.Focus();
            }

        }

        private void tsSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox ts = (ToolStripComboBox)sender;
            if (!ts.Focused)
                return;
            change();
        }

        private void tsBold_Click(object sender, EventArgs e)
        {
            change();
        }

        private void tsItalic_Click(object sender, EventArgs e)
        {
            change();
        }

        private void tsUnd_Click(object sender, EventArgs e)
        {
            change();
        }

        private void editor_SelectionChanged(object sender, EventArgs e)
        {
            if (editor.SelectionFont != null)
            {
                try
                {
                    tsFont.SelectedItem = editor.SelectionFont.FontFamily.Name;
                }
                catch
                {
                    tsFont.Text = "";
                }

                try
                {
                    tsSize.SelectedIndex = (int)editor.SelectionFont.Size - 5;

                }
                catch
                {
                    tsSize.Text = "";
                }

                try
                {
                    tsColor.SelectedItem = editor.SelectionColor.Name;

                }
                catch
                {
                    tsColor.Text = "";
                }
                if (editor.SelectionFont.Style.ToString().IndexOf("Bold") != -1)
                    tsBold.Checked = true;
                if (editor.SelectionFont.Style.ToString().IndexOf("Italic") != -1)
                    tsItalic.Checked = true;
                if (editor.SelectionFont.Style.ToString().IndexOf("Underline") != -1)
                    tsUnd.Checked = true;

            }
            else
            {
                tsSize.SelectedIndex = 7;
                tsFont.SelectedIndex = 12;
            }
        }
        private void tsFont_LostFocus(object sender, EventArgs e)
        {
            change();
        }
        private void save()
        {
            DialogResult fileLoc;
            if (filelocation == "")
            {
                svDialog.Filter = "Rich Text Format (*.rtf)|*.rtf";
                fileLoc = svDialog.ShowDialog();
                if (fileLoc == DialogResult.OK)
                {
                    editor.SaveFile(svDialog.FileName);
                    filelocation = svDialog.FileName;
                }
            }
            else
            {
                editor.SaveFile(filelocation);
            }
            simp = true;
        }

        private void mnSave_Click(object sender, EventArgs e)
        {
            try
            {
                save();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void mnSaveAs_Click(object sender, EventArgs e)
        {
            DialogResult fileLoc;
           
                svDialog.Filter = "Rich Text Format (*.rtf)|*.rtf";
                fileLoc = svDialog.ShowDialog();
                if (fileLoc == DialogResult.OK)
                {
                    editor.SaveFile(svDialog.FileName);
                    filelocation = svDialog.FileName;
                }
            
                simp = true;
        }

        private void mnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult fileLoc;
                if (!simp)
                {
                    fileLoc = MessageBox.Show("Apakah Anda ingin menyimpan file terlebih dahulu?", "Simpan file", MessageBoxButtons.YesNoCancel);
                    if (fileLoc == DialogResult.Cancel)
                    {
                        return;
                    }
                    else if (fileLoc == DialogResult.Yes)
                    {
                        save();
                    }
                }
                fileLoc = opDialog.ShowDialog();
                if (fileLoc == DialogResult.OK)
                {
                    filelocation = opDialog.FileName;
                    simp = true;
                    editor.LoadFile(opDialog.FileName);
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void editor_TextChanged(object sender, EventArgs e)
        {
            simp = false;
        }

        private void mnNew_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult fileLoc;
                if (!simp)
                {
                    fileLoc = MessageBox.Show("Apakah Anda ingin menyimpan file terlebih dahulu?", "Simpan file", MessageBoxButtons.YesNoCancel);
                    if (fileLoc == DialogResult.Cancel)
                    {
                        return;
                    }
                    else if (fileLoc == DialogResult.Yes)
                    {
                        save();
                    }
                }

                editor.Clear();
                filelocation = "";
                simp = false;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
        private void exit()
        {
            if (!simp)
            {
                DialogResult fileLoc;
                fileLoc = MessageBox.Show("Apakah Anda ingin menyimpan file terlebih dahulu?", "Simpan file", MessageBoxButtons.YesNo);
                if (fileLoc == DialogResult.No)
                {
                    Application.ExitThread();
                }
                else if (fileLoc == DialogResult.Yes)
                {
                    save();
                    Application.ExitThread();
                }
            }
            else
                Application.ExitThread();
        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            exit();
        }
    }
}
