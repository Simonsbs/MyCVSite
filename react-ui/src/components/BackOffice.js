import { Col, Container, Row } from "react-bootstrap";
import { Outlet } from "react-router-dom";
import SidePanel from "./SidePanel";

function BackOffice() {
  return (
    <Container fluid>
      <Row>
        <Col md={3}>
          <SidePanel />
        </Col>
        <Col md={9}>
          <h2>Welcome to the backoffice</h2>
          <Outlet />
        </Col>
      </Row>
    </Container>
  );
}

export default BackOffice;
