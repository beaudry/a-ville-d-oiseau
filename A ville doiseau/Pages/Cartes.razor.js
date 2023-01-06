const formatNombres = new Intl.NumberFormat('fr-CA', { maximumFractionDigits: 0 });
let cartesInitialisees = [];

export function CreerCartesDuQuebec(latitude, longitude) {
    const cartesDuQuebec = document.getElementsByClassName("carte-quebec");

    cartesInitialisees.forEach(carte => carte.remove());
    cartesInitialisees = [];

    for (let numeroCarte = 0; numeroCarte < cartesDuQuebec.length; numeroCarte++) {
        const elementCarteDuQuebec = cartesDuQuebec[numeroCarte];

        const pointDeDepart = L.latLng([latitude, longitude]);
        const pointArrivee = L.latLng([
            parseFloat(elementCarteDuQuebec.dataset["latitude"]),
            parseFloat(elementCarteDuQuebec.dataset["longitude"]),
        ]);
        const distance = L.CRS.Earth.distance(pointDeDepart, pointArrivee) / 1000;

        const carteDuQuebec = L.map(elementCarteDuQuebec, {
            attributionControl: false,
            zoomControl: false
        });
        cartesInitialisees.push(carteDuQuebec);

        if (distance > 50) {
            carteDuQuebec.setView([55, -68.511], 4);
        } else {
            carteDuQuebec.setView(pointDeDepart, 9);
        }


        L.tileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
            maxZoom: 19,
        }).addTo(carteDuQuebec);

        L.marker(pointDeDepart).addTo(carteDuQuebec);
        L.marker(pointArrivee).addTo(carteDuQuebec);

        elementCarteDuQuebec.parentElement.querySelector(".distance h2").textContent = formatNombres.format(distance) + " km";

        L.marker(latitude, longitude)
    }
}