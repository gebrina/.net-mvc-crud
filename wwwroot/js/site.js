const navbar = document.querySelector("nav");
const allLinks = navbar.querySelectorAll("a");
let activeLink = JSON.parse(localStorage.getItem("activeLink")) ?? "Home";

const handleActiveElement = (event) => {
  const currentElement = event?.target;
  const paths = location.pathname.substring(1).split("/");

  allLinks.forEach((link) => {
    if (currentElement) {
      link === currentElement &&
        localStorage.setItem("activeLink", JSON.stringify(link.textContent));
    } else {
      if (paths[0] === activeLink) {
        link.text === activeLink && link.classList.add("active");
      } else if (link.text === "Home" || link.text === " ") {
        link.classList.add("active");
        localStorage.removeItem("activeLink");
      }
    }
  });
};

handleActiveElement();

navbar.addEventListener("click", handleActiveElement);
