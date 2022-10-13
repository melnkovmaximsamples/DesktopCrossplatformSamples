import React, { useState } from "react";
import { useNavigate } from "react-router-dom";
import styled from "styled-components";
import { createMessage } from "../../services/messagesRequestSender";
import styles from './MessageCreationForm.module.css';

const MessageCreationForm = () => {
    const navigate = useNavigate();
    const [author, setAuthor] = useState<string>('');
    const [text, setText] = useState<string>('');
    const handleCreateMessage = (e: React.FormEvent) => {
        e.preventDefault();

        createMessage({ id: '', author: author, text: text });
        navigate('/');
    };

    return (
        <form className={styles.form} onSubmit={handleCreateMessage}>
            <div className={styles.flexContainer}>
                <label className={styles.label}>Author</label>
                <input className={styles.input} value={author} onChange={(e) => setAuthor(e.currentTarget.value)} type="text"/>
            </div>
            {!author && <span className={styles.error}>Не указан автор</span>}

            <div className={styles.flexContainer}>
                <label className={styles.label}>Text</label>
                <input className={styles.input} value={text} onChange={(e) => setText(e.currentTarget.value)} type="text"/>
            </div>
            {!text && <span className={styles.error}>Не указан текст</span>}

            <button className={styles.button} type="submit">Создать</button>
        </form>
    );
}

export default MessageCreationForm;