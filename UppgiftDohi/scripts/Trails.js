var Trails;
var Trail;
var map;

function centerTrail() {
    map.setCenter({
        lat: Trails[this.id].Polylines[0].Lat,
        lng: Trails[this.id].Polylines[0].Lng
    });
    map.setZoom(13);
}

function LoadTrails() {
    var div = document.getElementById("list-group");
    for (var i = 0; i < Trails.length; i++) {
        var a = document.createElement("a");
        a.className = "list-group-item";
        a.id = i;
        a.href = "#";
        a.onclick = centerTrail;
        var table = document.createElement("table");
        table.style.width = "100%";
        var tr = document.createElement("tr");
        var td = document.createElement("td");
        var h4 = document.createElement("h4");
        h4.className = "list-group-item-heading";

        var text = document.createTextNode(Trails[i].Name);
        h4.appendChild(text);
        td.rowSpan = 2;
        td.appendChild(h4);
        tr.appendChild(td);

        td = document.createElement("td");
        td.align = "center";
        td.innerHTML = "<span class='glyphicon glyphicon-star'></span>";
        tr.appendChild(td);

        td = document.createElement("td");
        td.align = "center";
        td.innerHTML = "<span class='glyphicon glyphicon-time'></span>";
        tr.appendChild(td);

        td = document.createElement("td");
        td.align = "center";
        td.innerHTML = "<span class='glyphicon glyphicon-option-horizontal'></span>";
        tr.appendChild(td);

        table.appendChild(tr);

        tr = document.createElement("tr");

        td = document.createElement("td");
        td.align = "center";
        td.innerHTML = Trails[i].Places.length;
        tr.appendChild(td);

        td = document.createElement("td");
        td.align = "center";
        td.innerHTML = Trails[i].Duration;
        tr.appendChild(td);

        td = document.createElement("td");
        td.align = "center";
        td.innerHTML = Trails[i].Length;
        tr.appendChild(td);

        table.appendChild(tr);


        a.appendChild(table);
        div.appendChild(a);
    }
}


function initMap() {
    var centerPos = { lat: 59.334415, lng: 18.110103 }
    map = new google.maps.Map(document.getElementById('map'), {
        zoom: 11,
        center: centerPos
    });

    for (var i = 0; i < Trails.length; i++) {
        var contentString = "<h4>" + Trails[i].Name + "</h4><p>" + Trails[i].Info + "</p>"
            + "<table style='width:100%'>" +
            "<tr>" +
            "<td><span class='glyphicon glyphicon-star'></span></td>" +
            "<td><span class='glyphicon glyphicon-time'></span></td>" +
            "<td><span class='glyphicon glyphicon-option-horizontal'></span></td>" +
            "</tr><tr>" +
            "<td>" + Trails[i].Places.length + "</td>" +
            "<td>" + Trails[i].Duration + "min</td>" +
            "<td>" + Trails[i].Length + "km</td>" +
            "</tr></table>";
        var latLng = new google.maps.LatLng(Trails[i].Polylines[0].Lat, Trails[i].Polylines[0].Lng);
        var marker = new google.maps.Marker({
            position: latLng,
            map: map,
            title: Trails[i].Name,
            infoText: contentString
        });

        var infowindow = new google.maps.InfoWindow({});
        marker.addListener('click', function () {
            infowindow.close();
            infowindow.setContent(this.infoText);
            infowindow.open(map, this);
            map.setCenter(this.getPosition());
        });

        var poly = new Array();
        for (var j = 0; j < Trails[i].Polylines.length; j++) {
            var pos = new google.maps.LatLng(Trails[i].Polylines[j].Lat, Trails[i].Polylines[j].Lng);
            poly.push(pos);
        }

        var Polylines = new google.maps.Polyline({
            path: poly,
            geodesic: true,
            strokeColor: '#FF0000',
            strokeOpacity: 1.0,
            strokeWeight: 2
        });
        Polylines.setMap(map);


        for (var j = 0; j < Trails[i].Places.length; j++) {
            var pos = new google.maps.LatLng(Trails[i].Places[j].Position.Lat, Trails[i].Places[j].Position.Lng);
            var contentString = "<h4>" + Trails[i].Places[j].Name + "</h4><p>" + Trails[i].Places[j].Info + "</p><img src='" + Trails[i].Places[j].Image + "' alt='Place'>";
            var marker = new google.maps.Marker({
                position: pos,
                map: map,
                title: Trails[i].Image,
                infoText: contentString,
                icon: "http://maps.google.com/mapfiles/ms/icons/green-dot.png"
            });

            var infowindow = new google.maps.InfoWindow({});
            marker.addListener('click', function () {
                infowindow.close();
                infowindow.setContent(this.infoText);
                infowindow.open(map, this);
            });
        }
        
    }
}
