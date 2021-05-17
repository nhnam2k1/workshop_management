using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Workshop_Management_OOD_W12
{
	public class GeneratingTextFile : IPrintWorkshop
	{
		public GeneratingTextFile()
		{
			
		}

        public void PrintData(Workshop[] workshops) {
            FileStream fs = null;
            StreamWriter sw = null;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save workshops as ";
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            try {
                string filename; 
                if (sfd.ShowDialog() == DialogResult.OK) 
                { 
                    filename = sfd.FileName;
                    fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                    sw = new StreamWriter(fs);

                    foreach(Workshop workshop in workshops)
                    {
                        sw.WriteLine(workshop.GetInfo());
                    }
                } 
                else { 
                    throw new Exception("You choose CANCEL, cannot generating file"); 
                }
            }
            catch(IOException ex) {
                throw ex;
            }
            catch(Exception ex) {
                throw ex;
            }
            finally {
                if (sw != null) {
                    sw.Close();
                }
            }
        }
    }
}
