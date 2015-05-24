<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FutureOfRetail.Dashboard" %>

<!DOCTYPE html>
<html>
<head>
  <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
  <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
  <title>Windows-8-like Animations with CSS3 and jQuery</title>

  <link rel="stylesheet" href="css/demo-styles.css" />
  <script src="Scripts/modernizr-2.6.2.js"></script>

</head>

<body>
 <header>
  
 </header>
  <!--===============================Start Demo====================================================-->
<div class="demo-wrapper">
<!-- classnames for the pages should include: 1) type of page 2) page name-->
<!--each tile should specify what page type it opens (to determine which animation) and the corresponding page name it should open-->
  <div class="dashboard clearfix">
    <ul class="tiles">
      <div class="col1 clearfix" onclick="location.href='addbeacon.aspx';">
        <li class="tile tile-big tile-1a slideTextUp" data-page-type="r-page" data-page-name="random-r-page">
          <div><p>Add new beacon</p></div>
          <div><p>Add new beacon</p></div>
        </li>
        <li class="tile tile-big tile-2a slideTextUp" data-page-type="r-page" data-page-name="random-r-page">
          <div><p>Add product</p></div>
          <div><p>Add product</p></div>
        </li>
      </div>

      <div class="col2 clearfix" onclick="location.href='allbeacons.aspx';">
        <li class="tile tile-big tile-1b slideTextUp" data-page-type="r-page" data-page-name="random-r-page">
          <div><p>See all beacons</p></div>
          <div><p>See all beacons</p></div>
        </li>
        <li class="tile tile-big tile-2b slideTextUp" data-page-type="r-page" data-page-name="random-r-page">
          <div><p>Feedback tool</p></div>
          <div><p>Feedback tool</p></div>
        </li>
      </div>

      <div class="col3 clearfix">      
        <li class="tile tile-big tile-1c slideTextUp" data-page-type="r-page" data-page-name="random-r-page" onclick="location.href='customerstatistics.aspx'">
          <div><p>See statistics</p></div>
          <div><p>See statistics</p></div>
        </li>
        <li class="tile tile-big tile-1b slideTextUp" data-page-type="r-page" data-page-name="random-r-page">
          <div><p>Help</p></div>
          <div><p>Help</p></div>
        </li>
      </div>
    </ul>
  </div><!--end dashboard-->
  <script src="Scripts/jquery-1.8.2.js"></script>
  <script src="Scripts/scripts.js"></script>

</body>
</html>

