import { useEffect, useState } from "react";
import api from "../utils/api";
import { Button, Table } from "react-bootstrap";
import { Link } from "react-router-dom";

function EducationList() {
  const [items, setItems] = useState([]);

  const handleDelete = (id) => {
    if (!window.confirm("Are you sure?")) {
      return;
    }

    api
      .delete(`education/${id}`)
      .then(() => {
        setItems(items.filter((item) => item.id !== id));
      })
      .catch((ex) => console.error(ex));
  };

  useEffect(() => {
    api
      .get("Education")
      .then((result) => {
        console.log(result.data);
        setItems(result.data);
      })
      .catch((ex) => console.error(ex));
  }, []);

  return (
    <>
      <h3>Education List</h3>
      <Button variant="primary" as={Link} to="new">
        Add New
      </Button>
      <Table striped bordered>
        <thead>
          <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Started</th>
            <th>Ended</th>
            <th>Description</th>
            <th>Skills</th>
            <th>Actions</th>
          </tr>
        </thead>
        <tbody>
          {items.map((item) => (
            <tr key={item.id}>
              <td>{item.id}</td>
              <td>{item.name}</td>
              <td>{new Date(item.started).toLocaleDateString()}</td>
              <td>
                {item.ended ? new Date(item.ended).toLocaleDateString() : "-"}
              </td>
              <td>{item.description}</td>
              <td>
                {item.skills ? (
                  items.skills.map((s) => s.name).join(" | ")
                ) : (
                  <>-</>
                )}
              </td>
              <td>
                <Button variant="info" as={Link} to={`edit/${item.id}`}>
                  Edit
                </Button>
                <Button variant="danger" onClick={() => handleDelete(item.id)}>
                  Delete
                </Button>
              </td>
            </tr>
          ))}
        </tbody>
      </Table>
    </>
  );
}

export default EducationList;
