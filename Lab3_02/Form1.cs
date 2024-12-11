using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_02
{
    public partial class Soanvanban : Form
    {
        public Soanvanban()
        {
            InitializeComponent();
        }

        private void TipDinhDang_Click(object sender, EventArgs e)
        {
            FontDialog fontDlg = new FontDialog();
            fontDlg.ShowColor = true;
            fontDlg.ShowApply = true;
            fontDlg.ShowEffects = true;
            fontDlg.ShowHelp = true;
            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                tipFont.ForeColor = fontDlg.Color;
                tipFont.Font = fontDlg.Font;
            }
        }
        private void loadFont()
        {
            foreach (FontFamily fontFamily in new InstalledFontCollection().Families)
            {
                tipFont.Items.Add(fontFamily.Name);
            }
            tipFont.SelectedItem = "Tahoma";
        }

        

        
        private void loadSize()
        {
            int[] sizeValues = new int[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            tipSize.ComboBox.DataSource = sizeValues;
            tipSize.SelectedItem = 14;
        }
        private void Soanvanban_Load(object sender, EventArgs e)
        {
            loadFont();
            loadSize();
            rtbVanBan.Font = new Font("Tahoma", 14, FontStyle.Regular);
        }

        private void tipMoFile_Click(object sender, EventArgs e)
        {
            rtbVanBan.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Filter = "Text files (*.txt)|*.txt|RichText files (*.rtf)|*.rtf";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;
                string savedFilePath = openFileDialog.FileName;
                try
                {
                    if (Path.GetExtension(selectedFileName).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        rtbVanBan.LoadFile(selectedFileName, RichTextBoxStreamType.PlainText);
                    }
                    else
                    {
                        rtbVanBan.LoadFile(selectedFileName, RichTextBoxStreamType.RichText);
                    }

                    MessageBox.Show("Tập tin đã được mở thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi trong quá trình mở tập tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tipCreateVB_Click(object sender, EventArgs e)
        {

        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            if (rtbVanBan.SelectionFont != null)
            {
                FontStyle style = rtbVanBan.SelectionFont.Style;
                if (rtbVanBan.SelectionFont.Bold)
                {
                    // Nếu văn bản đã đậm, xóa thuộc tính Bold ra khỏi FontStyle hiện tại
                    style &= ~FontStyle.Bold;
                }
                else
                {
                    // Nếu văn bản chưa đậm, thêm thuộc tính Bold vào FontStyle hiện tại
                    style |= FontStyle.Bold;
                }
                rtbVanBan.SelectionFont = new Font(rtbVanBan.SelectionFont, style);
            }
            
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Rich Text Format (*.rtf)|*.rtf|Plain Text (*.txt)|*.txt",
                Title = "Save File"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                if (saveFileDialog.FilterIndex == 1) // RTF file
                {
                    rtbVanBan.SaveFile(filePath, RichTextBoxStreamType.RichText);
                }
                else if (saveFileDialog.FilterIndex == 2) // Plain text file
                {
                    rtbVanBan.SaveFile(filePath, RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Rich Text Format (*.rtf)|*.rtf|Plain Text (*.txt)|*.txt",
                Title = "Open File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                if (openFileDialog.FilterIndex == 1) // RTF file
                {
                    rtbVanBan.LoadFile(filePath, RichTextBoxStreamType.RichText);
                }
                else if (openFileDialog.FilterIndex == 2) // Plain text file
                {
                    rtbVanBan.LoadFile(filePath, RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void btnItalicized_Click(object sender, EventArgs e)
        {
            if (rtbVanBan.SelectionFont != null)
            {
                FontStyle style = rtbVanBan.SelectionFont.Style;

                if (rtbVanBan.SelectionFont.Italic)
                {
                    
                    style &= ~FontStyle.Italic;
                }
                else
                {
                    
                    style |= FontStyle.Italic;
                }

                rtbVanBan.SelectionFont = new Font(rtbVanBan.SelectionFont, style);
            }
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            if (rtbVanBan.SelectionFont != null)
            {
                FontStyle style = rtbVanBan.SelectionFont.Style;

                if (rtbVanBan.SelectionFont.Underline)
                {
                    // If the text is already underlined, remove the Underline style
                    style &= ~FontStyle.Underline;
                }
                else
                {
                    // If the text is not underlined, add the Underline style
                    style |= FontStyle.Underline;
                }

                rtbVanBan.SelectionFont = new Font(rtbVanBan.SelectionFont, style);
            }S
        }
    }
}
