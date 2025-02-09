using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeePortal.Examples
{
    /*
         1kb = 1024 bytes
         8kb = 8*1024
         1MB = 1024 KB =>  1024 * 1024
     
     */
    public partial class FileUploadExample : System.Web.UI.Page
    {
        string[] AcceptedFileType = { ".png", ".jpg", ".jpeg" };
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int MaxFileSizeAllowed = (8 * 1024);

            if (!fileImage.HasFile)
            {
                ShowMessage("Info", "Please choose a file", MessageTyepe.info);
                return;
            }

            string fileExtension = Path.GetExtension(fileImage.FileName);

            

            if(!AcceptedFileType.Any(x => x == fileExtension))
            {
                ShowMessage("Info", $"Allowed file types are {string.Join(", ", AcceptedFileType)}", MessageTyepe.info);
                return;
            }

            int uploadedFileContentSize = fileImage.PostedFile.ContentLength;

            if(!(uploadedFileContentSize <= MaxFileSizeAllowed))
            {
                ShowMessage("Info", $"Maximum file size allowed is {MaxFileSizeAllowed} bytes", MessageTyepe.info);
                return;
            }

            string ServerFolder = "~/UploadedFiles";
            string physicalFolderPath =  Server.MapPath(ServerFolder);
            string fileName = fileImage.FileName;
            
            string GuidId = Guid.NewGuid().ToString();//dhjgdhygyfdgteu7658157
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fileName);
            fileName = $"{fileNameWithoutExtension}_{GuidId + fileExtension}";
            string filePath = Path.Combine(physicalFolderPath, fileName);
            fileImage.SaveAs(filePath);
            ShowMessage("Success", "File uploaded", MessageTyepe.success);
        }


        private void ShowMessage(string Title, string Message, MessageTyepe MessageType)
        {
            Random random = new Random();
            string toastrMessage = $"toastr[\"{MessageType.ToString()}\"](\"{Message}\", \"{Title} \")";
            ClientScript.
                   RegisterClientScriptBlock(this.GetType(),
                   random.Next().ToString(), toastrMessage, true);

        }
    }
}