@Code
    ViewData("Title") = "Kontak"
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

    .contact-container {
        display: flex;
        justify-content: center;
        gap: 30px;
        margin-top: 30px;
    }

    .contact-card {
        background: white;
        border-radius: 10px;
        box-shadow: 0 4px 10px rgba(0, 0, 0, 0.1);
        width: 150px;
        height: 150px;
        overflow: hidden;
        text-align: center;
        transition: transform 0.3s ease;
        padding: 20px;
    }

        .contact-card:hover {
            transform: translateY(-5px);
        }

        .contact-card img {
            width: 50px;
            height: 50px;
            object-fit: contain;
            margin-bottom: 15px;
        }

        .contact-card a {
            color: #2c3e50;
            font-size: 1.2em;
            text-decoration: none;
        }

            .contact-card a:hover {
                color: #3498db;
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
    <h2>Kontak Kami</h2>
    <div class="contact-container">
        <div class="contact-card">
            <img src="https://upload.wikimedia.org/wikipedia/commons/9/95/Instagram_logo_2022.svg" alt="Instagram">
            <a href="https://www.instagram.com" target="_blank">Instagram</a>
        </div>
        <div class="contact-card">
            <img src="https://upload.wikimedia.org/wikipedia/commons/6/6b/WhatsApp.svg" alt="WhatsApp">
            <a href="https://wa.me/1234567890" target="_blank">WhatsApp</a>
        </div>
        <div class="contact-card">
            <img src="https://upload.wikimedia.org/wikipedia/commons/5/51/Facebook_f_logo_%282019%29.svg" alt="Facebook">
            <a href="https://www.facebook.com" target="_blank">Facebook</a>
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
