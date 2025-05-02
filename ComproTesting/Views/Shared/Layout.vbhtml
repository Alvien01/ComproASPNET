<!DOCTYPE html>
<html lang="id">
<head>
    <meta charset="utf-8" />
    <title>@ViewData["Title"] - Company Profile</title>
    <link href="~/Content/Site.css" rel="stylesheet" />
</head>
<body>
    <!-- Header & Navbar -->
    <div class="header">
        <h1>Techno Tech</h1>
        <nav>
            @Html.ActionLink("Home", "Index", "Home") |
            @Html.ActionLink("Tentang", "Tentang", "Home") |
            @Html.ActionLink("Layanan", "Layanan", "Home") |
            @Html.ActionLink("Kontak", "Kontak", "Home")
        </nav>
    </div>

    <!-- Main Content -->
    <div class="main-content">
        @RenderBody()  <!-- Konten halaman yang sesuai akan ditampilkan di sini -->
    </div>

    <!-- Footer -->
    <footer class="footer">
        <p>&copy; 2025 CompanyName. All rights reserved.</p>
        <div class="footer-links">
            <a href="#">Privacy Policy</a> |
            <a href="#">Terms & Conditions</a>
        </div>
    </footer>
</body>
</html>
