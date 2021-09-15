<html>
    <head>
        <meta charset="UTF-8">
    <title>Register Form</title>
    <link rel="stylesheet" type="text/css" href="css/style.css">
    </head>
    <body>
        <div class="header">
            <h1>Register Form</h1>
        </div>
        
        <form  method="post" action="register2.php">
            <table> 
                <tr>
                    <td>Firstname:</td>
                    <td><input type="text" name="fname" placeholder="firstname" required></td>
                </tr>
                <tr>
                    <td>Lastname:</td>
                    <td><input type="text" name="lname" placeholder="lastname"  required></td>
                </tr>
                <tr>
                    <td>Email:</td>
                    <td><input type="email" name="email" pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,3}$" title="( e.g. xristos@hotmail.com )" placeholder="email" required></td>
                </tr>
                <tr>
                    <td>Phone Number:</td>
                    <td><input type="number" name="phone" pattern= "[0-9]{4}" title="Only numbers 0 to 10 ( e.g. 6974441569 )" placeholder="telephone" required></td>
                </tr>
                <tr>
                    <td>Username:</td>
                    <td><input type="text" name="username" placeholder="username" required></td>
                </tr>
                <tr>
                    <td>Password:</td>
                    <td><input type="password" name="password" pattern= "[0-9]{4}" title="Only 4 numbers ( e.g. 1234 )" placeholder="password" required></td>
                </tr>
                
                <tr>
                    <td></td>
                    <td><input type="submit" name="register_button" value="Register"/> <input type="submit" name="login_button" value="Login" onclick="location.href='login2.php';"/></td>
                </tr>
                
            </table>
            
        </form>
       
    </body>
</html>
