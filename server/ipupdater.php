<?php
date_default_timezone_set('Europe/London');

$ipStorageFile = "ip.store";
$redirectTimer = 1 * 5;


function getCurrentIP()
{
    $externalContent = file_get_contents('http://checkip.dyndns.com/');
    preg_match('/Current IP Address: \[?([:.0-9a-fA-F]+)\]?/', $externalContent, $m);
    $externalIP = $m[1];
    return $externalIP;
}

function getCachedIP()
{
    $ipStorageFileHandle2 = fopen($GLOBALS['ipStorageFile'], 'r') or die('Cannot open file!');
    $cachedIP = fread($ipStorageFileHandle2, filesize($GLOBALS['ipStorageFile']));
    echo "IN CACHE: ". $cachedIP ."<br>";

    fclose($ipStorageFileHandle2);
    return $cachedIP;
}

function setCachedIP()
{
    $ipStorageFileHandle = fopen($GLOBALS['ipStorageFile'], 'w') or die('Cannot open file');
    fwrite($ipStorageFileHandle, getCurrentIP());
    fclose($ipStorageFileHandle);
}


//ENTRY
if(filesize($ipStorageFile) < 1) {
    setCachedIP();
}
else
{


    //get the current ip and compare
    //update cache if needed
    if(getCurrentIP() != getCachedIP()) {
        echo "NOT MATCH: Updating cached IP <br>";
        setCachedIP();
    }

}

echo "Redirecting: " . date("h:i:s");
header("refresh:". $redirectTimer.";url=ipupdater.php");



