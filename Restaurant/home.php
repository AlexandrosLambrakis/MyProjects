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
   <li><a href="home.php">Home</a></li>
  <li><a href="booking.php">Booking</a></li>
  <li><a href="monitoring.php">Monitoring Reservations</a></li>
  <li><a href="contact.php">Contact</a></li>
  <li style="float:right"><a  href="logout.php">Logout</a></li>
  <li style="float:right"><a  href="register.php">Register New Customer</a></li>
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
<h2><center>ΜΕΝU</center></h2>
<p>&nbsp;</p>


<table>
<tr>
    <th width="213"><div align="center"><h3>ΣΠΑΓΓΕΤΙ ΝΑΠΟΛΙΤΖΑΝΑ</h3></div></th>
     <th width="600"><div align="right"><h3>ΠΕΡΙΓΡΑΦΗ ΠΙΑΤΟΥ</h3></div></th>
  </tr>
    <td><IMG ALIGN="Center" HEIGHT="200" WIDTH="400"  SRC="css\garida.jpg" class="magnify"/></td>
    <td><div align="right">
            <h4> Γαρίδες μέτριες κατά προτίμηση φρέσκιες
3- 4 κ.σ. ελαιόλαδο
1/2 κρεμμύδι ψιλοκομμένο
1 σκελίδα σκόρδο
1 καυτερή πιπερίτσα ή μπούκοβο
1/4 φλ. ούζο
1 πρεζα καστανή ζάχαρη (προαιρετικά)
400 γρ. ψιλοκομμένες ντομάτες φρέσκες ή κονκασέ
2 κ.γ. μαϊντανός ψιλοκομμένος
αλάτι
φρεσκοτριμμένο πιπέρι
300 γρ. σπαγγέτι</h4>
      <br>
    </div>
    </td>
</table>

<table>
<tr>
    <th width="213"><div align="center"><h3>ΛΑΖΑΝΙΑ ΜΕ ΛΑΧΑΝΙΚΑ</h3></div></th>
     <th width="600"><div align="right"><h3>ΠΕΡΙΓΡΑΦΗ ΠΙΑΤΟΥ</h3></div></th>
  </tr>
    <td><IMG ALIGN="Center" HEIGHT="200" WIDTH="400"  SRC="css\lazania.jpg" class="magnify"/></td>
    <td><div align="right">
            <h4> 18 λαζάνια
500 γρ. κατίκι
100 γρ. κεφαλοτύρι τριμμένο
300 γρ. κασέρι σε φέτες
2 κολοκύθια κομμένα σε καρέ
2 μελιτζάνες κομμένες σε καρέ
2 καρότα κομμένα σε λεπτές φέτες
500 γρ. μανιτάρια φρέσκα
1/4 φλ. ελαιόλαδο
1 κρεμμύδι κομμένο σε φέτες
Σάλτσα

1/4 φλ. ελαιόλαδο
1 σκ. σκόρδο
1 κιλό ντομάτες τριμμένες
αλάτι
πιπέρι
1 κλαδάκι φρέσκο θυμάρι
4 κ.σ. βασιλικός ψιλοκομμένος</h4>
      <br>
    </div>
    </td>
</table>
<table>
<tr>
    <th width="213"><div align="center"><h3>ΚΑΡΜΠΟΝΑΡΑ ΙΤΑΛΙΚΗ</h3></div></th>
     <th width="600"><div align="right"><h3>ΠΕΡΙΓΡΑΦΗ ΠΙΑΤΟΥ</h3></div></th>
  </tr>
    <td><IMG ALIGN="Center" HEIGHT="200" WIDTH="400"  SRC="css\karbonara.jpg" class="magnify"/></td>
    <td><div align="right">
            <h4>1 πακέτο Spaghetti n.5 Barilla (500 γραμ.)
2/3 φλυτζ. παντσέτα ή guanciale (ή μπέικον) κομμένα σε μακρόστενα κομματάκια
2 κ.σ. ελαιόλαδο
1 σκελίδα σκόρδο καθαρισμένη, ολόκληρη ή σπασμένη (όχι λιωμένη)
3 αβγά (σε θερμοκρασία δωματίου)
3/4 φλυτζ. φρεσκοτριμμένο πεκορίνο ή παρμιτζιάνο
αλάτι και φρεσκοτριμμένο πιπέρι</h4>
      <br>
    </div>
    </td>
</table>
<table>
<tr>
    <th width="213"><div align="center"><h3>ΣΦΟΥΡΙΧΤΑ ΜΑΚΑΡΟΝΙΑ ΜΕ ΤΟΝΟ</h3></div></th>
     <th width="600"><div align="right"><h3>ΠΕΡΙΓΡΑΦΗ ΠΙΑΤΟΥ</h3></div></th>
  </tr>
    <td><IMG ALIGN="Center" HEIGHT="200" WIDTH="400"  SRC="css\makaronia.jpg" class="magnify"/></td>
    <td><div align="right">
            <h4>3 κ.σ. ελαιόλαδο για το σοτάρισμα
1 μέτριο κρεμμύδι ψιλοκομμένο
1 σκ. σκόρδο ψιλοκομμένη
2 πιπεριές κόκκινες Φλωρίνης ή άλλες κομμένες σε μικρούς κύβους 0,5 εκ.
10 κλαράκια φρέσκο θυμάρι
400 γρ χρωματιστά ντοματίνια κομμένα στη μέση
300 γρ τόνος Αλοννήσου σε κονσέρβα (καθαρό βάρος)
400 γρ σιουφηχτά μακαρόνια
3 κ.σ. κάπαρη καλά ξεπλυμένη για το σερβίρισμα
αλάτι και πιπέρι
</h4>
      <br>
    </div>
    </td>
</table>

</div>
    
<footer>Copyright</footer>

</body>
</html>
