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
  <li><a href="Home2.php">Home</a></li>
   <li><a href="Booking3.php">Booking</a></li>
    <li><a href="Monitoring2.php">Monitoring Reservations</a></li>
  <li><a href="Contact2.php">Contact</a></li>
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
<h2><center>BOOKING</center></h2>
<p>&nbsp;</p>   

<link rel="stylesheet" href="css/bform.css">
<form  method="post" action="booking4.php">
            <table> 
                <tr>
                    <td>Date:</td>
                    <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <title>jQuery UI Datepicker - Default functionality</title>
  <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
  <link rel="stylesheet" href="/resources/demos/style.css">
  <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
  <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
  <script>
  $( function() {
    $( "#datepicker" ).datepicker();
  } );
  </script>
                    <td><input type="text" id="datepicker" name="date"></td>
                </tr>
                <tr>
                    <td>Time:</td>
                    <td>
                        <style>select{
    border: 3px solid #111;
    padding :20px 0px;
   width: 121%;
   margin-bottom: 25px;
}
</style>
                        <select name="time" id="time">
	<option value="5:00 AM">5:00 AM</option>
	<option value="6:00 AM">6:00 AM</option>
	<option value="7:00 AM">7:00 AM</option>
	<option value="8:00 AM">8:00 AM</option>
	<option value="9:00 AM">9:00 AM</option>
	<option value="10:00 AM">10:00 AM</option>
	<option value="11:00 AM">11:00 AM</option>
	<option value="12:00 PM">12:00 PM</option>
	<option value="13:00 PM">13:00 PM</option>
	<option value="14:00 PM">14:00 PM</option>
	<option value="15:00 PM">15:00 PM</option>
	<option value="16:00 PM">16:00 PM</option>
	<option value="17:00 PM">17:00 PM</option>
	<option value="18:00 PM">18:00 PM</option>
	<option value="19:00 PM">19:00 PM</option>
	<option value="20:00 PM">20:00 PM</option>
	<option value="21:00 PM">21:00 PM</option>
	<option value="22:00 PM">22:00 PM</option>
	<option value="23:00 PM">23:00 PM</option>
        <option value="24:00 PM">24:00 PM</option>
                       </select></td>
                </tr>
                <tr>
                    <td>Persons:</td>
                    <td><input type="number" name="persons" ></td>
                </tr>
                <tr>
                    <td>Table:</td>
                    <td><input type="number" name="tables"  required></td>
                </tr>
                <tr>
                    <td></td>
                    <td><input type="submit" name="book_button" value="Book Now"/></td>
                </tr>
               
            </table>
            
        </form>
</div>


<footer>Copyright</footer>

</div>

</body>
</html>
