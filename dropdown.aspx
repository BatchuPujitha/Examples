<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dropdown.aspx.cs" Inherits="DotnetProject.Assignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/dropdown.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <pre>
            <label>Gender: </label><select onchange="Validate(this.value)">
                                   <option value="select">Select-Gender</option>
                                   <option value="male">male</option>
                                   <option value="female">female</option>
                                   <option value="others">others</option>
                                   </select>
            </pre>
            <label>Gender : </label>
            <input type="radio" id="male" name="gender" value="male" />Male <input type="radio" id="female" name="gender" value="female"/>Female<input type="radio" id="others" name="gender" value="others" />Others<br />
            <br /><input type="submit" id="submit" value="Register"/>
        </div>
    </form>
</body>
</html>
