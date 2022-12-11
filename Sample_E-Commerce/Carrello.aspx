<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="Sample_E_Commerce.Carrello" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
    <asp:GridView ID="GridCarrello" CssClass="table table-bordered table-striped" runat="server"
         AutoGenerateColumns="false" ItemType="Sample_E_Commerce.Prodotto" >
            <Columns>
                <asp:TemplateField HeaderText="Foto" ItemStyle-CssClass="w-25">
                    <ItemTemplate>
                         <img src="<%# Item.Immagine %>" class="card-img-top" alt="Foto_Prodotto">             
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Prodotto">
                    <ItemTemplate>
                         <p><%# Item.NomeProdotto %></p>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Prezzo">
                    <ItemTemplate>                       
                         <p><%# Item.Prezzo.ToString("c2") %></p>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
        <div class="container">
           <div>
               <p class="float-end">Totale da pagare: <asp:Label ID="lblTotCarrello" runat="server" Text=""></asp:Label></p>
           </div>
        </div>
</asp:Content>
