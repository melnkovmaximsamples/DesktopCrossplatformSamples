import { NavLink } from "react-router-dom";
import styled, { css } from "styled-components";

const MessageMenu = () => {
    const Container = styled.div`
        display: flex;
        justify-content: space-around;
        padding: 5px;
    `;

    const buttonStyles = css`
        text-decoration: none;
        color: #000;
        font-size: 16px;
        font-family: 'Times New Roman', Times, serif;
        border: 2px solid #fff;
        border-radius: 50px;
        background-color: #fff;
        padding: 14px 28px;
        cursor: pointer;
        display: inline-block;

        &:hover {
            color: #fff;
            background-color: #000;
        }
    `;

    const Link = styled(NavLink)`
        ${buttonStyles}
    `;
    const Button = styled.button`
        ${buttonStyles}  
    `;

    const handleRemoveAll = () => {
        
    }

    return (
        <Container>
            <Link to="/">Все сообщения</Link>
            <Link to="new">Добавить сообщение</Link>
            <Button onClick={handleRemoveAll}>Удалить все</Button>
        </Container>
    )
};

export default MessageMenu;