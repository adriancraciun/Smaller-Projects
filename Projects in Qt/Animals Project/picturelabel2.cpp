#include "picturelabel2.h"
#include <QWidget>
#include <QMouseEvent>
#include <QApplication>

PictureLabel2::PictureLabel2(QWidget* parent)
{
    QPixmap pix(":/Images/Images/FoxWinterImage.jpg");
    setPixmap(pix.scaled(400, 400));
    setAlignment(Qt::AlignCenter);
    setFocus();
}

void PictureLabel2::enterEvent(QEvent *event)
{
    QPixmap pix(":/Images/Images/FoxImage.jpg");
    setPixmap(pix.scaled(400, 400));
    setFocus();
}

void PictureLabel2::leaveEvent(QEvent *event)
{
    QPixmap pix(":/Images/Images/FoxWinterImage.jpg");
    setPixmap(pix.scaled(400, 400));
    setFocus();
}

void PictureLabel2::mousePressEvent(QMouseEvent *event)
{
    setFocus();
    Qt::MouseButton btn = event->button();

    switch (btn)
    {
        case Qt::LeftButton :
        {
             QPixmap pix(":/Images/Images/WinterFoxImage1.jpg");
             setPixmap(pix.scaled(400, 400));
             break;
        }
        case Qt::MiddleButton :
        {
             QPixmap pix(":/Images/Images/WinterFoxImage2.jpg");
             setPixmap(pix.scaled(400, 400));
             break;
        }
        case Qt::RightButton :
        {
             QPixmap pix(":/Images/Images/WinterFoxImage3.jpg");
             setPixmap(pix.scaled(400, 400));
             break;
        }
        default :
            QLabel::mousePressEvent(event);
    }
}
