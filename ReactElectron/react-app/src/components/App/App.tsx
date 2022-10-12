import React from "react";
import logo from "./logo.svg";
import "./App.css";
import MessageMenu from "../MessageMenu/MessageMenu";
import MessageCollection from "../MessagesCollection/MessageCollection";
import MessageCreationForm from "../MessageCreationForm/MessageCreationForm";
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";
import styled from "styled-components";

function App() {
    const Container = styled.div`
        margin: 0 auto;
        width: 900px;
        height: 100%;
        min-height: 100vh;
        background-color: bisque;
    `;

    return (
        <Container>
            <Router>
                <MessageMenu />
                <Routes>
                    <Route path="/" element={<MessageCollection />} />
                    <Route path="/new" element={<MessageCreationForm />} />
                </Routes>
            </Router>
        </Container>
    );
}

export default App;
