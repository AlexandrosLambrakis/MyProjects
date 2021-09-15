<?php session_start();
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
<h2><center>MONITORING RESERVATIONS</center></h2>
<p>&nbsp;</p>   

<form align="center" method="post" action="booking2.php">
   
          

<table width="400" border="0" align="center" cellpadding="3" cellspacing="0">
<tr>
    <td><strong><center><h2>View Reservations</h2></center></strong></td>
</tr>
</table>
<br>



<?php 
include 'config.php';

$sql = "SELECT * FROM book";
$result = mysqli_query($conn,$sql);

   $table="";
 
 while ($row = mysqli_fetch_array($result,MYSQLI_ASSOC)){

   $table.='<tr><th>ID</th>
    <th>Username</th>
    <th>Date</th>
    <th>Time</th>
    <th>Persons</th>
    <th>Table</th>
    <tr>
    <form  method="get">
      <td>'.$row['id'].'</td>
    <td>'.$row['username'].'</td>
    <td>'.$row['date'].'</td>
    <td>'.$row['time'].'</td>
    <td>'.$row['persons'].'</td>
    <td>'.$row['tables'].'</td>
            </form>
  </tr>';
   
 }
 
?>
<table align="center" border="1">
  <?php echo "$table";
  ?>
</table>



</div>




<footer>Copyright</footer>

</div>

</body>
</html>
