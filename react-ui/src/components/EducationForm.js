import { useState } from "react";
import { Form, Button } from "react-bootstrap";

function EducationForm() {
  const [name, setName] = useState("");
  const [started, setStarted] = useState("");
  const [ended, setEnded] = useState("");
  const [description, setDescription] = useState("");

  const handleSubmit = (e) => {
    e.preventDefault();
  };

  return (
    <>
      <h2>Education form add / edit</h2>
      <Form onSubmit={handleSubmit}>
        <Form.Group>
          <Form.Label>Name</Form.Label>
          <Form.Control type="text" value={name} required />
        </Form.Group>
        <Form.Group>
          <Form.Label>Started</Form.Label>
          <Form.Control type="date" value={started} required />
        </Form.Group>
        <Form.Group>
          <Form.Label>Ended</Form.Label>
          <Form.Control type="date" value={ended} />
        </Form.Group>
        <Form.Group>
          <Form.Label>Description</Form.Label>
          <Form.Control type="textarea" value={description} required />
        </Form.Group>
        <Button variant="primary" type="submit">
          Save
        </Button>
        <Button variant="secondary">Cancel</Button>
      </Form>
    </>
  );
}

export default EducationForm;
