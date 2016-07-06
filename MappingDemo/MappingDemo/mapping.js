﻿var map;
function initMap() {
    map = new google.maps.Map(document.getElementById('map'), {
        center: { lng: -0.495813898207, lat: 51.3820387641 },
        zoom: 20
    });

    var flightPlanCoordinates = [
{ lat: 37.772, lng: -122.214 },
{ lat: 21.291, lng: -157.821 },
{ lat: -18.142, lng: 178.431 },
{ lat: -27.467, lng: 153.027 }
    ];
    var flightPath = new google.maps.Polyline({
        path: flightPlanCoordinates,
        geodesic: true,
        strokeColor: '#FF0000',
        strokeOpacity: 1.0,
        strokeWeight: 2,
        draggable: true
    });

    flightPath.setMap(map);
}