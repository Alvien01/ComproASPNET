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

    p {
        text-align: center;
        font-size: 1.1em;
        line-height: 1.6;
        background-color: #ffffff;
        margin: 20px auto;
        padding: 20px;
        border-radius: 10px;
        width: 80%;
        max-width: 600px;
        box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
    }

    .footer {
        background-color: #34495e;
        color: black;
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

<h2>Kontak</h2>
<p>
    Email: info@company.com<br />
    Telepon: +62 812-3456-7890<br />
    Alamat: Jl. Contoh Alamat No. 123, Jakarta
</p>

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
