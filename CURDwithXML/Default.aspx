<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CURDwithXML._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h1>Xml File Data</h1>
        <p class="lead">Read data from xml file</p>
    </div>

    <asp:GridView ID="GridViewResult" runat="server" CssClass="table table-striped" AutoGenerateColumns="False" EnableViewState="true" OnRowCommand="GridViewResult_RowCommand">
        <Columns>
            <asp:TemplateField>
                <HeaderTemplate>SNo</HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="SNo" runat="server" Text='<%# Eval("SNo")%>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <HeaderTemplate>AltPhones_Tam1</HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="AltPhones_Tam1" CssClass="AltPhones_Tam1" runat="server" Text='<%# Eval("AltPhones_Tam1")%>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <HeaderTemplate>AltPhones_Tam2</HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="AltPhones_Tam2" CssClass="AltPhones_Tam2" runat="server" Text='<%# Eval("AltPhones_Tam2")%>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <HeaderTemplate>AltPhones_Tam1VM</HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="AltPhones_Tam1VM" CssClass="AltPhones_Tam1VM" runat="server" Text='<%# Eval("AltPhones_Tam1VM")%>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <HeaderTemplate>AltPhones_Tam2VM</HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="AltPhones_Tam2VM" CssClass="AltPhones_Tam2VM" runat="server" Text='<%# Eval("AltPhones_Tam2VM")%>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <HeaderTemplate>AltCode_Tam1</HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="AltCode_Tam1" CssClass="AltCode_Tam1" runat="server" Text='<%# Eval("AltCode_Tam1")%>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <HeaderTemplate>AltCode_Tam2</HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="AltCode_Tam2" CssClass="AltCode_Tam2" runat="server" Text='<%# Eval("AltCode_Tam2")%>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <HeaderTemplate>AltHunt_G1</HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="AltHunt_G1" CssClass="AltPhones_Tam1" runat="server" Text='<%# Eval("AltHunt_G1")%>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <HeaderTemplate>AltHunt_G2</HeaderTemplate>
                <ItemTemplate>
                    <asp:Label ID="AltHunt_G2" CssClass="AltHunt_G2" runat="server" Text='<%# Eval("AltHunt_G2")%>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <HeaderTemplate></HeaderTemplate>
                <ItemTemplate>
                    <asp:LinkButton ID="btnSelect" CssClass="btn btn-default" CommandArgument='<%# Eval("SNo") %>' runat="server" Text="Edit" CommandName="EditRow" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

</asp:Content>
