﻿const navbar = document.querySelector("nav");
const allLinks = navbar.querySelectorAll("a");
let activeLink = JSON.parse(localStorage.getItem("activeLink")) ?? "Home";

const handleActiveElement = (event) => {
  const currentElement = event?.target;
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
