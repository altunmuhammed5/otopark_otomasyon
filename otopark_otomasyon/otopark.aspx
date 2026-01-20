<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="otopark.aspx.cs" Inherits="otopark_otomasyon.otopark" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server"> 
        <div>
    <table>
    
        <tr>
            <td> </td>
        </tr>
         <tr>
            <td class="auto-style1">
                <asp:Button ID="aracekle_btn" runat="server" Text="Araç ekle" OnClick="aracekle_btn_Click" Width="205px" />
             </td>
        </tr>
 
    </table>
            <br />
     </div>  
        <asp:ListBox ID="ListBox1" runat="server" Height="367px" Width="100%"></asp:ListBox>
        
        
        
    </form>
</body>
</html>
