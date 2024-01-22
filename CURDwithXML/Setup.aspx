<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Setup.aspx.cs" Inherits="CURDwithXML.Setup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div class="form-horizontal">
            <h4>Alternates</h4>
            <hr />
            <asp:Label runat="server" ID="errMsg" CssClass="danger"></asp:Label>
            <div class="form-group">
                <div class="col-md-2">
                    <asp:Label runat="server" ID="lblSno">SNo</asp:Label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="SNo" CssClass="form-control" Enabled="false"></asp:TextBox>
                </div>
            </div>

            <div class="form-group">
                <div class="col-md-2">
                    <asp:Label runat="server" ID="lblAltPhones_Tam1">AltPhones_Tam1</asp:Label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="AltPhones_Tam1" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-2">
                    <asp:Label runat="server" ID="lblAltPhones_Tam2">AltPhones_Tam2</asp:Label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="AltPhones_Tam2" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-2">
                    <asp:Label runat="server" ID="lblAltPhones_Tam1VM">AltPhones_Tam1VM</asp:Label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="AltPhones_Tam1VM" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-2">
                    <asp:Label runat="server" ID="lblAltPhones_Tam2VM">AltPhones_Tam2VM</asp:Label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="AltPhones_Tam2VM" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-2">
                    <asp:Label runat="server" ID="lblAltCode_Tam1">AltCode_Tam1</asp:Label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="AltCode_Tam1" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-2">
                    <asp:Label runat="server" ID="lblAltCode_Tam2">AltCode_Tam2</asp:Label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="AltCode_Tam2" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-2">
                    <asp:Label runat="server" ID="lblAltHunt_G1">AltHunt_G1</asp:Label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="AltHunt_G1" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-2">
                    <asp:Label runat="server" ID="lblAltHunt_G2">AltHunt_G2</asp:Label>
                </div>
                <div class="col-md-10">
                    <asp:TextBox runat="server" ID="AltHunt_G2" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" ID="btnSave" CssClass="btn btn-primary" Text="Save" OnClick="btnSave_Click" />
            </div>
        </div>
    </div>

    </div>
</asp:Content>
