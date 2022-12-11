<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Sample_E_Commerce.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div class="container">
            <div class="card mb-3">
                <div class="row g-0">
                    <div class="col-4">
                        <img src="img/logo2.png" class="img-fluid rounded-start" alt="logo">
                    </div>
                    <div class="col-8">
                        <div class="card-body mt-5">
                            <h2 class="card-title">Make Your Pet Happy</h2>
                            <p class="card-text">Tutto quello che il tuo amico a quattro zampe desidera..</p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="container mb-3">
             <div class="row row-cols-1 row-cols-md-3 g-5 justify-content-center">
                <asp:Repeater ID="Repeater1" runat="server" ItemType="Sample_E_Commerce.Prodotto">
                <ItemTemplate>
                    <div class="col d-flex justify-content-center">
                        <div class="card text-center align-items-center" id="cardProduct">
                            <div class="img-cont">

                                <a href="Dettagli.aspx?Id=<%# Item.Id %>">
                                    <img src="<%# Item.Immagine %>" class="card-img-top" alt="Foto_Prodotto"></a>
                            </div>
                            <div class="card-body">
                                <h5 class="card-title"><%# Item.NomeProdotto %></h5>
                                <hr />
                                <p class="card-text">Prezzo: <%# Item.Prezzo.ToString("c2") %></p>
                            </div>

                        </div>
                    </div>
                </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>

</asp:Content>
