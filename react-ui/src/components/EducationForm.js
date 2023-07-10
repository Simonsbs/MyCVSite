import { useEffect, useState } from "react";
import { Form, Button } from "react-bootstrap";
import api from "../utils/api";
import { useNavigate, useParams } from "react-router-dom";

function EducationForm() {
  const { id } = useParams();
  const [skillsList, setSkillsList] = useState([]);

  const [name, setName] = useState("");
  const [started, setStarted] = useState("");
  const [ended, setEnded] = useState("");
  const [description, setDescription] = useState("");
  const [skills, setSkills] = useState([]);
  const navigate = useNavigate();

  useEffect(() => {
    api
      .get("programmingskill")
      .then((res) => setSkillsList(res.data))
      .catch((ex) => console.error(ex));
  }, []);

  useEffect(() => {
    if (id) {
      api
        .get(`education/${id}`)
        .then((res) => {
          const item = res.data;

          setName(item.name);

          let tempDate = new Date(item.started);
          setStarted(tempDate.toISOString().split("T")[0]);

          if (item.ended) {
            tempDate = new Date(item.ended);
            setEnded(tempDate.toISOString().split("T")[0]);
          }

          setDescription(item.description);

          setSkills(item.skills || []);
        })
        .catch((ex) => console.error(ex));
    }
  }, [id]);

  const handleCancel = () => {
    navigate("../education");
  };

  const handleSubmit = (e) => {
    e.preventDefault();

    const newItem = {
      id: id || 0,
      name,
      started,
      ended: ended || null,
      description,
      skills: skills,
    };
    const verb = id ? "put" : "post";

    console.log(newItem);

    api[verb]("education", newItem)
      .then((res) => {
        console.log(res.data);
        navigate("../education");
      })
      .catch((ex) => console.error(ex));
  };

  return (
    <>
      <h2>Education form add / edit</h2>
      <Form onSubmit={handleSubmit}>
        <Form.Group>
          <Form.Label>Name</Form.Label>
          <Form.Control
            type="text"
            value={name}
            required
            onChange={(e) => setName(e.target.value)}
          />
        </Form.Group>
        <Form.Group>
          <Form.Label>Started</Form.Label>
          <Form.Control
            type="date"
            value={started}
            required
            onChange={(e) => setStarted(e.target.value)}
          />
        </Form.Group>
        <Form.Group>
          <Form.Label>Ended</Form.Label>
          <Form.Control
            type="date"
            value={ended}
            onChange={(e) => setEnded(e.target.value)}
          />
        </Form.Group>
        <Form.Group>
          <Form.Label>Description</Form.Label>
          <Form.Control
            type="textarea"
            value={description}
            required
            onChange={(e) => setDescription(e.target.value)}
          />
        </Form.Group>
        <Form.Group>
          <Form.Label>Skills</Form.Label>
          <Form.Control
            as="select"
            multiple
            value={skills}
            onChange={(e) =>
              setSkills(Array.from(e.target.selectedOptions, (o) => o.value))
            }
          >
            {skillsList.map((skill) => (
              <option key={skill.id} value={skill.id}>
                {skill.name}
              </option>
            ))}
          </Form.Control>
        </Form.Group>
        <Button variant="primary" type="submit">
          Save
        </Button>
        <Button variant="secondary" onClick={handleCancel}>
          Cancel
        </Button>
      </Form>
    </>
  );
}

export default EducationForm;
