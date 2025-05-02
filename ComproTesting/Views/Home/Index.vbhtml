<!DOCTYPE html>
<html lang="id">
<head>
    <meta charset="utf-8" />
    <title>@ViewBag.Title Company Profile</title>
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
    <!-- Hero Section -->
    <div class="hero">
        <div class="hero-overlay">
            <h1>Selamat Datang di <span class="brand">Techno Tech</span></h1>
            <p>Mitra terbaik Anda dalam solusi bisnis profesional.</p>
            <a href="@Url.Action("Layanan", "Home")" class="btn-primary">Lihat Layanan</a>
        </div>
    </div>

    <!-- Content Section -->
    <div class="content-section">
        <h2>Tentang Kami</h2>
        <p>Kami adalah perusahaan yang bergerak di bidang penyediaan layanan dan solusi terbaik untuk kebutuhan bisnis Anda. Dengan tim yang profesional dan berpengalaman, kami siap membantu Anda tumbuh dan berkembang.</p>
    </div>

    <div class="content-section">
        <h2>Layanan Kami</h2>
        <ul>
            <li>Konsultasi Bisnis</li>
            <li>Pengembangan Aplikasi</li>
            <li>Layanan IT Support</li>
            <li>Pelatihan dan Workshop</li>
        </ul>
    </div>

    <div class="content-section">
        <h2>Hubungi Kami</h2>
        <p>
            Email: info@company.com<br />
            Telepon: +62 812-3456-7890<br />
            Alamat: Jl. Contoh Alamat No. 123, Jakarta
        </p>
    </div>

    <!-- Footer -->
    <footer class="footer">
        <p>&copy; 2025 CompanyName. All rights reserved.</p>
        <div class="footer-links">
            <a href="#">Privacy Policy</a> |
            <a href="#">Terms & Conditions</a>
        </div>
    </footer>

    <!-- Scripts (optional) -->
    <script src="~/Scripts/jquery-3.6.0.min.js"></script>
</body>
</html>
