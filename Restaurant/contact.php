<?php
session_start();
?>
<!DOCTYPE html>
<html>
<head>
<link rel="stylesheet" href="css/style1.css">

</head>
<body background="images.jpg">
<header>
   <ul>
   <h1>Restaurant Spaggetoni Alexander</h1><p align="left"><b id="welcome">Welcome : <i><?php echo  $_SESSION["login_user"] ; ?></i></b></p>
   <p align="left"><b id="welcome">Your Role : <i><?php echo  $_SESSION["role_user"] ; ?></i></b></p>
  <li><a href="Home.php">Home</a></li>
   <li><a href="Booking.php">Booking</a></li>
    <li><a href="Monitoring.php">Monitoring Reservations</a></li>
  <li><a href="Contact.php">Contact</a></li>
  <li style="float:right"><a  href="logout.php">Logout</a></li>
</ul>
</header>
<div style=" margin: auto;
    width: 60%;
    border: 10px solid #d9d9d9
;
    padding: 50px;height:1500px;
background-color:#d9d9d9;">

<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<p>&nbsp;</p>
<h2><center>CONTACT</center></h2>
<p>&nbsp;</p>   



<table align="center">
<tr>
<td width="80%">
  <h2 align="center">Restaurant Spaggetoni Alexander</h2>
  <h2 align="center">Φοιτητής στο Μητροπολητικό Κολλέγιο</h2>
  <h2 align="center">Μενιππου 39</h2>
  <h2 align="center">15772, Αθήνα(Ζωγράφου)</h2>

  <h2 align="center">Τηλέφωνο:+30 210.77.51.852</h2>
  <h2 align="center">Kινητό: +30 698.98.68.783</h2>

  <h2 align="center">email: respaggetoni@hotmail.gr</h2>
</td>
</tr>
</table>
</div>



<footer>Copyright</footer>

</div>

</body>
</html>
