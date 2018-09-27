<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="GTICLOUD.Dashboard" %>

<%@ Register Src="~/CssControl.ascx" TagPrefix="uc1" TagName="CssControl" %>
<%@ Register Src="~/JsScriptControl.ascx" TagPrefix="uc1" TagName="JsScriptControl" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <uc1:CssControl runat="server" ID="CssControl" />
</head>
<body>
    <uc1:JsScriptControl runat="server" ID="JsScriptControl" />
    <form id="form1" runat="server">
    <div>
        <h1>Welcome to Dashboard</h1>
    </div>
    </form>
</body>
</html>
