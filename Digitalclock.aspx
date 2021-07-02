<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Digitalclock.aspx.cs" Inherits="DotnetProject.Digitalclock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="Scripts/Digitalclock.js"></script>
    <title></title>
</head>
<body onload="display_currenttime()">
    <form id="form1" runat="server">
        <div>
            <span id='currenttime' ></span>
        </div>
    </form>
</body>
</html>
