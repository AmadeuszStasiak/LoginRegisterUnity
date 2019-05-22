<?php

	$polaczenie = @new mysqli('localhost','root','','unity');
	
	if($polaczenie->connect_errno == 0)
	{
		if(isset($_POST['nick']) && isset($_POST['pass']) )
		{
			$nick = $_POST['nick'];
			$pass = $_POST['pass'];
			
			$rezultat = mysqli_query($polaczenie, "SELECT * FROM gracze WHERE nick='$nick' AND pass='$pass'");
			
			if($rezultat->num_rows != 0)
			{
				echo 'Zalogowano pomyślnie';
			}
			else
			{
				echo 'Teki użytkownik nie istnieje';
			}
		}
		
		$polaczenie->close();		
	}
?>