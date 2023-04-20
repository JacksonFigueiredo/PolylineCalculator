# PolylineCalculator

An application will be created to compute Station and Offset between a point and a polyline, where 
“Offset” is defined to be the smallest perpendicular distance to the polyline from the given Point, and 
“Station” is defined to be the distance from the start of the polyline, along the polyline, down to the 
location on the polyline where the smallest perpendicular line from the Point intersects the polyline.

The application will read a polyline from an ASCII file and allow the user to enter an Easting and 
Northing value (x y coordinate). The application will then compute the Station and Offset of the point 
to the polyline and display the coordinates to the user.
Polyline File Format
The polyline file will be an ASCII comma separated file containing Easting and Northing values. The 
polyline file will only contain data (i.e. no header).