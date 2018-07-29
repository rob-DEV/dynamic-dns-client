<?php

function getCachedIP()
{
    $ipStorageFileHandle2 = fopen("ip.store", 'r') or die('Cannot open file!');
    $cachedIP = fread($ipStorageFileHandle2, filesize("ip.store"));
    fclose($ipStorageFileHandle2);
    return $cachedIP;
}


?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>MAIN DYNDNS</title>
</head>
<body style="margin:0px;padding:0px;">

<iframe <?php echo "src=\"http://".getCachedIP().":7824\" ";?> style="overflow:hidden;overflow-x:hidden;overflow-y:hidden;height:100%;width:100%;position:absolute;top:0px;left:0px;right:0px;bottom:0px" height="100%" width="100%">

</iframe>


</body>
</html>
