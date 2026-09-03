@model GaziKultur.Entity.Concrete.Muze

@{
    ViewData["Title"] = "Müze Güncelle";
}

< style >
    .admin - form - page {
background: #f4f6f8;
        min - height: 100vh;
padding: 40px 20px 70px;
}

    .admin - form - container {
    max - width: 950px;
margin: auto;
}

    .form - card {
background: white;
    border - radius: 16px;
padding: 30px;
border: 1px solid #e4e9ee;
        box - shadow: 0 6px 24px rgba(0,0,0,.06);
}

    .form - header {
    margin - bottom: 25px;
}

    .form - header h1 {
        margin: 0 0 7px;
color: #17283f;
        font - size: 30px;
font - weight: 700;
    }

    .form - header p {
        margin: 0;
color: #6c7885;
    }

    .form - grid {
display: grid;
    grid - template - columns: repeat(2, 1fr);
gap: 18px;
}

    .form - group {
display: flex;
    flex - direction: column;
gap: 7px;
}

    .form - group.full {
    grid - column: 1 / -1;
}

    .form - group label {
        color: #253a50;
        font - size: 13px;
font - weight: 700;
    }

    .form - control {
width: 100 %;
padding: 11px 12px;
border: 1px solid #dce3e9;
        border - radius: 8px;
background: #fff;
        color: #263747;
        outline: none;
}

    .form - control:focus {
        border-color: #294866;
        box - shadow: 0 0 0 3px rgba(41,72,102,.08);
    }

    textarea.form - control {
resize: vertical;
    min - height: 110px;
}

    .checkbox - area {
display: flex;
    align - items: center;
gap: 8px;
    margin - top: 8px;
}

    .button - area {
display: flex;
    justify - content: flex - end;
gap: 10px;
    margin - top: 25px;
}

    .geri - btn,
    .kaydet - btn {
padding: 11px 18px;
    border - radius: 8px;
    text - decoration: none;
    font - weight: 600;
border: none;
cursor: pointer;
}

    .geri - btn {
background: #eef2f5;
        color: #31485e;
    }

    .kaydet - btn {
background: #1e3a56;
        color: white;
}

    .kaydet - btn:hover {
        background: #142a40;
    }

    @@media(max - width: 750px) {
        .form - grid {
        grid - template - columns: 1fr;
    }

        .form - group.full {
        grid - column: auto;
    }

        .button - area {
        flex - direction: column;
    }

        .geri - btn,
        .kaydet - btn {
    width: 100 %;
        text - align: center;
    }
}
</ style >

< div class= "admin-form-page" >

    < div class= "admin-form-container" >

        < div class= "form-card" >

            < div class= "form-header" >
                < h1 > Müze Güncelle </ h1 >
                < p > Seçilen müzenin bilgilerini düzenleyebilirsiniz.</p>
            </div>

            <form asp-controller="AdminMuze"
                  asp-action="Guncelle"
                  method="post">

                @Html.AntiForgeryToken()

                <input type="hidden" asp-for="MuzeID" />

                <div asp-validation-summary="ModelOnly"
                     style="color:red; margin-bottom:15px;">
                </div>

                <div class= "form-grid" >

                    < div class= "form-group" >
                        < label asp -for= "Isim" > Müze Adý </ label >
                        < input asp -for= "Isim"
                               class= "form-control" />
                    </ div >

                    < div class= "form-group" >
                        < label asp -for= "Ilce" > Ýlçe </ label >
                        < input asp -for= "Ilce"
                               class= "form-control" />
                    </ div >

                    < div class= "form-group full" >
                        < label asp -for= "KisaAciklama" > Kýsa Açýklama </ label >
                        < textarea asp -for= "KisaAciklama"
                                  class= "form-control" >
                        </ textarea >
                    </ div >

                    < div class= "form-group full" >
                        < label asp -for= "Tarihce" > Tarihçe </ label >
                        < textarea asp -for= "Tarihce"
                                  class= "form-control" >
                        </ textarea >
                    </ div >

                    < div class= "form-group full" >
                        < label asp -for= "Adres" > Adres </ label >
                        < input asp -for= "Adres"
                               class= "form-control" />
                    </ div >

                    < div class= "form-group" >
                        < label asp -for= "ZiyaretGunleri" > Ziyaret Günleri </ label >
                        < input asp -for= "ZiyaretGunleri"
                               class= "form-control" />
                    </ div >

                    < div class= "form-group" >
                        < label asp -for= "GirisUcreti" > Giriþ Ücreti </ label >
                        < input asp -for= "GirisUcreti"
                               class= "form-control" />
                    </ div >

                    < div class= "form-group" >
                        < label asp -for= "AcilisSaati" > Açýlýþ Saati </ label >
                        < input asp -for= "AcilisSaati"
                               class= "form-control" />
                    </ div >

                    < div class= "form-group" >
                        < label asp -for= "KapanisSaati" > Kapanýþ Saati </ label >
                        < input asp -for= "KapanisSaati"
                               class= "form-control" />
                    </ div >

                    < div class= "form-group full" >
                        < label asp -for= "Resim" > Kapak Fotoðraf Yolu </ label >
                        < input asp -for= "Resim"
                               class= "form-control" />
                    </ div >

                    < div class= "form-group full" >
                        < label asp -for= "HaritaLinki" > Harita Linki </ label >
                        < input asp -for= "HaritaLinki"
                               class= "form-control" />
                    </ div >

                    < div class= "form-group full" >

                        < div class= "checkbox-area" >

                            < input asp -for= "Aktif" />

                            < label asp -for= "Aktif" >
                                Müze aktif olarak yayýnlansýn
                            </ label >

                        </ div >

                    </ div >

                </ div >

                < div class= "button-area" >

                    < a asp - controller = "AdminMuze"
                       asp - action = "Index"
                       class= "geri-btn" >
                        Geri Dön
                    </ a >

                    < button type = "submit"
                            class= "kaydet-btn" >
                        Deðiþiklikleri Kaydet
                    </ button >

                </ div >

            </ form >

        </ div >

    </ div >

</ div >