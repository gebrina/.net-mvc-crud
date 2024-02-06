const navbar = document.querySelector("nav");
const allLinks = navbar.querySelectorAll("a");
let activeLink = JSON.parse(localStorage.getItem("activeLink")) ?? "Home";

const handleActiveElement = (event) => {
  const currentElement = event?.target;
  if (activeLink !== location.pathname.substring(1) && !currentElement) {
    location.href = location.origin + "/" + activeLink;
  }
  allLinks.forEach((link) => {
    if (currentElement) {
      link === currentElement &&
        localStorage.setItem("activeLink", JSON.stringify(link.textContent));
    } else {
      link.text === activeLink && link.classList.add("active");
    }
  });
};

handleActiveElement();

navbar.addEventListener("click", handleActiveElement);
