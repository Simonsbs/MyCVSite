import { Navigate } from 'react-router-dom'
function Protected({ children }) {
	const isAuthenticated = Boolean(localStorage.getItem("mycvsite_token"));

	if (isAuthenticated) {
		return children;
	}

	return <Navigate to='/login'/> ;
}

export default Protected