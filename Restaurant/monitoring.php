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
<h2><center>MONITORING RESERVATIONS</center></h2>
<p>&nbsp;</p>   


<table width="400" border="1" align="center" cellpadding="5" cellspacing="5">
<tr>
    <td><strong><center><h2>View Reservations</h2></center></strong></td>
</tr>
</table>
<br>



<?php 
include 'config.php';

$sql = "SELECT * FROM book";
if(!$result = mysqli_query($conn,$sql)) {
    exit(mysql_error());
}

 $table="";
 
 while ($row = mysqli_fetch_array($result,MYSQLI_ASSOC)){
     
   $table.='<tr><th>ID</th>
    <th>Username</th>
    <th>Date</th>
    <th>Time</th>
    <th>Persons</th>
    <th>Table</th>
    <th>Edit</th>
    <th>Delete</th></tr>
    <tr>
      <td>'.$row['id'].'</td>
    <td>'.$row['username'].'</td>
    <td><input type=text name=date value='.$row['date'].'></td>
    <td><input type=text name=time value='.$row['time'].'></td>
    <td><input type=text name=persons value='.$row['persons'].'></td>
    <td><input type=text name=tables value='.$row['tables'].'></td>
        <td><a href="update.php?id=$row[id]?date=$row[date]?time=$row[time]?persons=$row[persons]?tables=$row[tables]">Update</a></td>
        <td><a href="delete.php?id='.$row['id'].'">Delete</a></td>
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
