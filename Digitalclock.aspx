<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Digitalclock.aspx.cs" Inherits="DotnetProject.Digitalclock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script type="text/javascript">
        function display_refreshtime() {
            var refresh = 1000;
            mytime = setTimeout('display_currenttime()', refresh)
        }

        function display_currenttime() {
            var x = new Date()
            document.getElementById('currenttime').innerHTML = x;
            display_refreshtime();
        }
    </script>
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
