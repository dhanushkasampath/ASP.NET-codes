<?php
session_start();
if(!session_is_registered(myusername)){
header("location:main_login.php");
}
?>

<html>
<body>
Login Successful
you can do what ever you like here!!!

<form method="get" action="logout.php">
    <button type="submit">logout</button>
</form>

</body>
</html>