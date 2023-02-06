import React, { Component } from 'react';
import { Navigate, Route, Routes } from "react-router-dom";
import Layout from './scenes/layout';
import './custom.css';
import { CssBaseline, ThemeProvider } from "@mui/material";
import { createTheme } from "@mui/material/styles";
import { useMemo } from "react";
import { useSelector } from "react-redux";
import { themeSettings } from "./theme.js";
import Dashboard from "./scenes/dashboard";
import { BrowserRouter as Router } from 'react-router-dom';

/*export default class App extends Component {
    static displayName = App.name;

    render() {
        return (
            <Layout>
                <Routes>
                    {AppRoutes.map((route, index) => {
                        const { element, ...rest } = route;
                        return <Route key={index} {...rest} element={element} />;
                    })}
                </Routes>
            </Layout>
        );
    }
}*/

function App() {
    const mode = useSelector((state) => state.global.mode);
    const theme = useMemo(() => createTheme(themeSettings(mode)), [mode]);
    return (
        <div className="app">
            <ThemeProvider theme={theme}>
                <CssBaseline />
                <Router>
                    <Routes>
                        <Route element={<Layout />}>
                            <Route index path="/" element={<Navigate to="/dashboard" replace />} />
                            <Route path="/dashboard" element={<Dashboard />} />
                        </Route>
                    </Routes>
                </Router>
            </ThemeProvider>
        </div>
    );
}

export default App;