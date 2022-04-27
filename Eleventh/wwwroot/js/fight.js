let strong = document.getElementById("strong");
let fast = document.getElementById("fast");
const queryString = window.location.search;
const urlParams = new URLSearchParams(queryString);

strong.addEventListener("click", (e) => {
    alert("You hit really hard. Something screamed and pushed you.");
    window.location.href = "/Place?id=" + urlParams.get('id');
})
fast.addEventListener("click", (e) => {
    alert("You move fast and punch enemy in face. He is not impressed, not at all.");
})