import { BrowserRouter, Routes, Route } from "react-router-dom";
import Protected from "./components/Protected";
import Login from "./components/Login";
import BackOffice from "./components/BackOffice";
import EducationList from "./components/EducationList";
import EducationForm from "./components/EducationForm";
function App() {
  return (
    <BrowserRouter>
      <h1>Welcome to my site, this is my CV..</h1>
      <Routes>
        <Route path="/login" element={<Login />} />
        <Route
          path="/backoffice"
          element={
            <Protected>
              <BackOffice />
            </Protected>
          }
        >
          <Route path="education" element={<EducationList />} />
          <Route path="education/new" element={<EducationForm />} />
          <Route path="education/edit/:id" element={<EducationForm />} />
        </Route>
        <Route path="/" element={<div>Home</div>} />
      </Routes>
    </BrowserRouter>
  );
}

export default App;
