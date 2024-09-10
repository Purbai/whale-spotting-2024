import { fireEvent, render, screen } from "@testing-library/react"
import { MemoryRouter, Route, Routes } from "react-router-dom";
import Hamburger from "../Hamburger/Hamburger";
import { CreateUser } from "../pages/CreateUser";
import Home from "../pages/Home";
import Explore from "../pages/Explore";

describe("Menu toggles on/off when hamburger button clicked", () => {

    test("menu class is menu menu-open when hamburger button is clicked", () => {
        render(
            <MemoryRouter>
                <Hamburger />
            </MemoryRouter>,
        )

        const button = screen.getByTestId("toggle-button");
        fireEvent.click(button);

        const menu = screen.getByTestId("menu");
        expect(menu).toHaveClass("menu menu-open");
    });

    test("menu class is menu menu-hidden when hamburger button is not clicked", () => {
        render(
            <MemoryRouter>
                <Hamburger />
            </MemoryRouter>,
        )

        const menu = screen.getByTestId("menu");
        expect(menu).toHaveClass("menu menu-hidden");
    });
});

describe("Menu contains all the navigation items", () => {

    test("menu has navigation items bar", () => {
        render(
            <MemoryRouter>
                <Hamburger />
            </MemoryRouter>
        )

        const navigationLinks = screen.getByTestId("navigationLinks");
        expect(navigationLinks).toBeInTheDocument();
    });

    test("menu has home link", () => {
        render(
            <MemoryRouter>
                <Hamburger />
            </MemoryRouter>
        )

        const home = screen.getByText("Home");

        expect(home).toBeInTheDocument();
        expect(home).toHaveAttribute("href", "/");
    });

    test("menu has explore link", () => {
        render(
            <MemoryRouter>
                <Hamburger />
            </MemoryRouter>
        )

        const explore = screen.getByText("Explore");
        expect(explore).toBeInTheDocument();
        expect(explore).toHaveAttribute("href", "/explore");
    });

    test("menu has log in button", () => {
        render(
            <MemoryRouter>
                <Hamburger />
            </MemoryRouter>
        )

        const button = screen.getByTestId("log-in-button");
        expect(button).toBeInTheDocument();
    });

    test("menu has sign up button", () => {
        render(
            <MemoryRouter>
                <Hamburger />
            </MemoryRouter>
        )

        const button = screen.getByTestId("sign-up-button");
        expect(button).toBeInTheDocument();
    });
});

describe("Buttons go to correct pages", () => {

    test("go to log in page when log in button is clicked", async () => {
        render(
            <MemoryRouter>
                <Routes>
                    <Route path="/" element={<Home />} />
                    <Route path="/explore" element={<Explore />} />
                    <Route path="/login" element={<h1>Log in</h1>} />
                    <Route path="/signup" element={<CreateUser />} />
                </Routes>
                <Hamburger />
            </MemoryRouter>,
        )

        const button = screen.getByTestId("log-in-button");
        fireEvent.click(button);
        const logInHeading = await screen.findByRole('heading', { name: /log in/i });
        expect(logInHeading).toBeInTheDocument();  
    });


    test("go to sign up page when sign up button is clicked", async () => {
        render(
            <MemoryRouter>
                <Routes>
                    <Route path="/" element={<Home />} />
                    <Route path="/explore" element={<Explore />} />
                    <Route path="/login" element={<h1>Log in</h1>} />
                    <Route path="/signup" element={<CreateUser />} />
                </Routes>
                <Hamburger />
            </MemoryRouter>,
        )

        const button = screen.getByTestId("sign-up-button");
        fireEvent.click(button);
        const signUpHeading = await screen.findByRole('heading', { name: /sign up/i });
        expect(signUpHeading).toBeInTheDocument();  
    });

});