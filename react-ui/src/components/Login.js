import { useState } from "react";
import api from "../utils/api";
import { useNavigate } from "react-router-dom";

function Login() {
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");
  const [error, setError] = useState("");
  const nav = useNavigate();

  const handleSubmit = (e) => {
    e.preventDefault();

    const loginData = {
      username,
      password,
    };

    api
      .post("Login", loginData)
      .then((result) => {
        setError(`result.status = (${result.status})`);
        if (result.status === 200) {
          localStorage.setItem("mycvsite_token", result.data);
          console.log("Logged in - success");
          nav("/backoffice");
        } else {
          localStorage.setItem("mycvsite_token", "");
          setError(`could not login (${result.status})`);
        }
      })
      .catch((ex) => {
        localStorage.setItem("mycvsite_token", "");
        setError(ex);
        console.error(ex);
      });
  };

  return (
    <>
      <form onSubmit={handleSubmit}>
        <label>
          Username:
          <input
            type="text"
            value={username}
            placeholder="enter your username"
            onChange={(e) => setUsername(e.target.value)}
          />
        </label>
        <br />
        <label>
          Password:
          <input
            type="password"
            value={password}
            placeholder="enter your password"
            onChange={(e) => setPassword(e.target.value)}
          />
        </label>
        <br />
        <button type="submit">Login</button>
      </form>
      {error !== "" ?? <h3>Error during login</h3>}
    </>
  );
}

export default Login;
