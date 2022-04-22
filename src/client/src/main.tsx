import React from "react";
import ReactDOM from "react-dom";

import { configuration } from "./configuration";
import { App } from "./App";

ReactDOM.render(
  <React.StrictMode>
    <App {...configuration} />
  </React.StrictMode>,
  document.getElementById("root")
);
