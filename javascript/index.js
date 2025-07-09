
const objetHTML = [
    new HTML(findElementVal("typebalise"), findElementVal("contenu"), findElementVal("backgroundimageurl"), findElementVal("backgroundcolor"), findElementVal("couleurcontenu"), findElementVal("padding"), findElementVal("stylecustom"))
];

/// Ma fonction pour rapidement trouver les valeurs d'ID html
function findElementVal(nom) {
    return $("#" + nom).val();
}




function validation(){

    // Nous validons la licence dabord
    let licenceValide = $("#licence").val();
    if(!licenceValide) return; // invalide so bye

    // Tout est good, on generate
    generate();
};




function generate() {
    const objetHTML = [
        new HTML(findElementVal("typebalise"), findElementVal("contenu"), findElementVal("backgroundimageurl"), findElementVal("backgroundcolor"), findElementVal("couleurcontenu"), findElementVal("padding"), findElementVal("stylecustom"))
    ];

    localStorage.setItem("HTML", JSON.stringify(objetHTML));
    
    console.log(objetHTML.toString());
    document.location.href = "generation.html";
}
