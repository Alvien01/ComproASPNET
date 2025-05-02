@Code
    ViewData("Title") = "Layanan"
End Code
<style>
    body {
        font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        margin: 0;
        padding: 0;
        background: #f9f9f9;
        color: #333;
    }

    .header {
        background-color: #2c3e50;
        color: white;
        padding: 20px;
        text-align: center;
    }

        .header h1 {
            margin: 0;
            font-size: 2.5em;
        }

    nav {
        margin-top: 10px;
    }

        nav a {
            color: #ecf0f1;
            text-decoration: none;
            margin: 0 10px;
            font-weight: bold;
        }

            nav a:hover {
                text-decoration: underline;
            }

    h2 {
        text-align: center;
        color: #34495e;
        margin-top: 30px;
    }

    .content-section {
        padding: 20px;
        max-width: 1200px;
        margin: auto;
    }

    .card-container {
        display: flex;
        flex-wrap: wrap;
        justify-content: center;
        gap: 20px;
        margin-top: 30px;
    }

    .card {
        background: white;
        border-radius: 10px;
        box-shadow: 0 4px 10px rgba(0, 0, 0, 0.1);
        width: 260px;
        overflow: hidden;
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
        }

        .card h3 {
            margin: 15px 10px 10px;
            font-size: 1.2em;
            color: #2c3e50;
        }

        .card p {
            padding: 0 15px 20px;
            font-size: 0.95em;
            color: #666;
        }

    .footer {
        background-color: #34495e;
        color: white;
        text-align: center;
        padding: 15px;
        margin-top: 40px;
    }

    .footer-links a {
        color: #ecf0f1;
        text-decoration: none;
        margin: 0 8px;
    }

        .footer-links a:hover {
            text-decoration: underline;
        }
</style>

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

<div class="content-section">
    <h2>Layanan Kami</h2>
    <div class="card-container">
        <div class="card">
            <img src="https://via.placeholder.com/260x160?text=Konsultasi" alt="Konsultasi Bisnis">
            <h3>Konsultasi Bisnis</h3>
            <p>Membantu Anda menyusun strategi bisnis yang efektif dan efisien.</p>
        </div>
        <div class="card">
            <img src="https://via.placeholder.com/260x160?text=App+Dev" alt="Pengembangan Aplikasi">
            <h3>Pengembangan Aplikasi</h3>
            <p>Membuat aplikasi web dan mobile yang inovatif dan andal.</p>
        </div>
        <div class="card">
            <img src="https://via.placeholder.com/260x160?text=IT+Support" alt="Layanan IT Support">
            <h3>Layanan IT Support</h3>
            <p>Dukungan teknis profesional untuk infrastruktur TI Anda.</p>
        </div>
        <div class="card">
            <img src="https://via.placeholder.com/260x160?text=Workshop" alt="Pelatihan dan Workshop">
            <h3>Pelatihan & Workshop</h3>
            <p>Meningkatkan keterampilan tim Anda dengan pelatihan langsung.</p>
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
