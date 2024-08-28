<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GeneratePDF.aspx.cs" Inherits="MayBatch1WebApplication1.GeneratePDF" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Generate Offer Letter</title>
    <style type="text/css">
        .center-form {
            margin: auto;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 10px;
            max-width: 600px;
            background-color: #f9f9f9;
        }
        .center-form h2 {
            text-align: center;
            margin-bottom: 20px;
        }
        .form-control {
            width: 100%;
            padding: 10px;
            margin: 5px 0;
            box-sizing: border-box;
        }
        .btn {
            display: block;
            width: 100%;
            padding: 10px;
            margin-top: 20px;
            background-color: #4CAF50;
            color: white;
            border: none;
            cursor: pointer;
            border-radius: 5px;
            text-align: center;
        }
        .btn:hover {
            background-color: #45a049;
        }
        .form-group {
            margin-bottom: 15px;
        }
        label {
            display: block;
            margin-bottom: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="center-form">
            <h2>Generate Offer Letter</h2>
            <div class="form-group">
                <label for="TextBox1">Emp Full Name:</label>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="TextBox2">Email ID:</label>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="TextBox3">Date of Joining:</label>
                <asp:TextBox ID="TextBox3" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
            </div>
            <asp:Button ID="GenerateButton" runat="server" Text="Generate Offer Letter" CssClass="btn" OnClick="GenerateButton_Click" />
        </div>
    </form>
</body>
</html>
