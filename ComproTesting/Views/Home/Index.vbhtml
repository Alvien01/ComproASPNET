<!DOCTYPE html>
<html lang="id">
<head>
    <meta charset="utf-8" />
    <title>@ViewBag.Title Company Profile</title>
    <link href="~/Content/Site.css" rel="stylesheet" />
    <style>
        /* Styling for the cards */
        .card-container {
            display: flex;
            justify-content: space-around;
            flex-wrap: wrap;
            gap: 20px;
            margin-top: 30px;
        }

        .card {
            background: #fff;
            border-radius: 10px;
            box-shadow: 0 4px 10px rgba(0, 0, 0, 0.1);
            width: 260px;
            padding: 20px;
            text-align: center;
            transition: transform 0.3s ease;
        }

            .card:hover {
                transform: translateY(-5px);
            }

            .card img {
                width: 100%;
                height: 160px;
                object-fit: cover;
                border-radius: 10px;
            }

            .card h3 {
                margin-top: 15px;
                font-size: 1.5em;
                color: #2c3e50;
            }

            .card p {
                margin-top: 10px;
                font-size: 1em;
                color: #555;
            }

        .btn-primary {
            background-color: #f39c12;
            color: white;
            padding: 10px 20px;
            text-decoration: none;
            font-size: 1.1em;
            border-radius: 5px;
            margin-top: 15px;
        }

            .btn-primary:hover {
                background-color: #e67e22;
            }
    </style>
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

    <!-- Content Section - Product & Services -->
    <div class="content-section">
        <h2>Produk & Layanan Kami</h2>
        <div class="card-container">
            <div class="card">
                <img src="https://via.placeholder.com/260x160?text=Konsultasi" alt="Konsultasi Bisnis">
                <h3>Konsultasi Bisnis</h3>
                <p>Membantu Anda menyusun strategi bisnis yang efektif dan efisien.</p>
                <a href="@Url.Action("Layanan", "Home")" class="btn-primary">Selengkapnya</a>
            </div>
            <div class="card">
                <img src="https://via.placeholder.com/260x160?text=App+Dev" alt="Pengembangan Aplikasi">
                <h3>Pengembangan Aplikasi</h3>
                <p>Membuat aplikasi web dan mobile yang inovatif dan andal.</p>
                <a href="@Url.Action("Layanan", "Home")" class="btn-primary">Selengkapnya</a>
            </div>
            <div class="card">
                <img src="https://via.placeholder.com/260x160?text=IT+Support" alt="Layanan IT Support">
                <h3>Layanan IT Support</h3>
                <p>Dukungan teknis profesional untuk infrastruktur TI Anda.</p>
                <a href="@Url.Action("Layanan", "Home")" class="btn-primary">Selengkapnya</a>
            </div>
            <div class="card">
                <img src="https://via.placeholder.com/260x160?text=Workshop" alt="Pelatihan dan Workshop">
                <h3>Pelatihan & Workshop</h3>
                <p>Meningkatkan keterampilan tim Anda dengan pelatihan langsung.</p>
                <a href="@Url.Action("Layanan", "Home")" class="btn-primary">Selengkapnya</a>
            </div>
        </div>
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
