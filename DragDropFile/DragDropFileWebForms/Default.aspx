<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DragDropFileWebForms.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div ondrop ="handleDnDFileSelect(event)" ondragover="handleDragOver(event)" style="width: 400px; height: 100px; border-style: dashed;">
            Drag and drop files from your machine on this box.
        </div>
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" style="visibility:hidden" />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click" />
        <br />
        <asp:Panel ID="Panel1" runat="server" ondrop ="handleDnDFileSelect(event)" ondragover="handleDragOver(event)" style="width: 400px; height: 100px; border-style: dashed;">
            Drag and drop files from your machine on this box.
        </asp:Panel>
    </form>

    <script>
        var files;

        function handleDragOver(event) {
            event.stopPropagation();
            event.preventDefault();
        }

        var counterId = 0;
        function handleDnDFileSelect(event) {
            event.stopPropagation();
            event.preventDefault();

            /* Read the list of all the selected files. */
            files = event.dataTransfer.files;

            /* Consolidate the output element. */
            //var form = document.getElementById('form1');
            //var data = new FormData(form);

            var dropZone = document.createElement('div');

            for (var i = 0; i < files.length; i++)
            {
                //part back
                var hiddenBytes = document.createElement('input');
                hiddenBytes.id = "FileDrop_hiddenBytes" + counterId;
                hiddenBytes.setAttribute('type', 'hidden');
                hiddenBytes.setAttribute('name', 'FileDrop_hiddenBytes' + counterId);

                var hiddenName = document.createElement('input');
                hiddenName.id = "FileDrop_hiddenName" + counterId;
                hiddenName.setAttribute('type', 'hidden');
                hiddenName.setAttribute('name', 'FileDrop_hiddenName' + counterId);
                hiddenName.value = files[i].name;

                var reader = new FileReader();

                reader.onload = function (e) {
                    var comma = e.target.result.indexOf(',');
                    var base64 = e.target.result.substr(comma + 1);

                    hiddenBytes.value = base64;
                    console.log('leyendo el archivo');
                }

                reader.readAsDataURL(files[i]);

                document.forms[0].appendChild(hiddenBytes);
                document.forms[0].appendChild(hiddenName);

                //part front
                var fileName = document.createTextNode(files[i].name);
                dropZone.appendChild(fileName);

                var breakLine = document.createElement('br');
                dropZone.appendChild(breakLine);

                counterId++;
            }

            document.forms[0].appendChild(dropZone);
        }
    </script>

</body>
</html>
