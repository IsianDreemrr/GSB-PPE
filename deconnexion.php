<?php

//-- NOTE : Cette page déconnexion est pas nécessairement utile et pourrait être
//remplacée par un block directement dans le header, pour afficher le statut de connexion/le bouton déconnexion.

//Inclusion du header (en attendant)
include "header.php";

//Ajouter lien avec BDD (une fois qu'elle sera peuplé avec des entrées)




?>
<div class="Logout">

<?php

//Variable token pour check la connection en permanence
$IsConnected = IsLoggedIn();

//==== FONCTIONS (A mettre dans une classe (user potentiellement ?))

//Check si connecté ou pas (A changer selon )
function IsLoggedIn() 
{
	if (session_status() == "PHP_SESSION_ACTIVE")
   // if ($SESSION["username"])
	{
		return True;
	}
	else return False;

}

//Déconnexion, qui détruit la session et recharge la page
function LogOut() 
{
    session_destroy();
    header("location:index.php");
}


            //(PHP) Si connecté, affiche l'username 
            //et le lien de déconnexion
            if (IsLoggedIn() == true)
            {
                echo "Vous êtes connecté en tant que <b>";
                // echo $_SESSION["username"]; 
                 echo "</b></br>";

                 ?>
                 	<div class="deconnecter">
	                <form action="" name="deconnexion" method="post">
	                <input type="submit" name="deconnexion" id="deconnexion" value="Se déconnecter" />
	                </form>
	                </div>
                <?php
	
   
            }
            //Si non connecté, affiche le lien de connexion
            //et le lien d'inscription
            else
            {
            ?>
                Connectez-vous à votre espace utilisateur (ou créez-en un !)

                <?php
            }

            if ($IsConnected)
            {
                echo "(Connecté)";
            }

            if(isset($_POST["deconnexion"]))
            {
                LogOut();
            }


            
    //       if(isset($_POST["SessionTest"]))
    //            {
    //                echo "aled";
    //                session_start();
    //                
    //            }

           ?>
            
    </br></br>

            <form action="./connexion/connexion.php" name="SessionTest" method="post">
	            <input type="submit" name="SessionTest" id="SessionTest" value="Se connecter" />
	        </form>

            <form action="./inscription/inscription.php" name="SessionTest" method="post">
	            <input type="submit" name="SessionTest" id="SessionTest" value="S'inscrire" />
	        </form>
                    





</div>

<!-- css temporaire juste pour afficher le cadre-->
<style>
.Logout {
    color:white;
    width: 50%;
    height: 50%;
	display:inline-block;
    margin-top: 70px;
    margin-left: auto ; 
	margin-right: auto;
    font-size: 18px;
    border: 0px solid black;
    padding: 10px;
    align-items: center;
    justify-content: space-between;
    background: linear-gradient(90deg, black, 50%, white);
}


</style>

<?php
include "footer.php";
?>