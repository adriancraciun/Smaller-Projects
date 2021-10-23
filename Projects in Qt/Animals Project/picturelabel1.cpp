#include "picturelabel1.h"
#include <QWidget>
#include <QMouseEvent>
#include <QApplication>

PictureLabel1::PictureLabel1(QWidget* parent)
{
    QPixmap pix(":/Images/Images/BearWinterImage.jpg");
    setPixmap(pix);
    setAlignment(Qt::AlignCenter);
    setFocus();
}

void PictureLabel1::enterEvent(QEvent *event)
{
    QPixmap pix(":/Images/Images/BearImage.jpg");
    setPixmap(pix.scaled(400, 400));;
    setFocus();
}

void PictureLabel1::leaveEvent(QEvent *event)
{
    QPixmap pix(":/Images/Images/BearWinterImage.jpg");
    setPixmap(pix.scaled(400, 400));
    setFocus();
}

void PictureLabel1::mousePressEvent(QMouseEvent *event)
{
    setFocus();
    Qt::MouseButton btn = event->button();

    switch (btn)
    {
        case Qt::LeftButton :
        {
             QPixmap pix(":/Images/Images/PolarBearImage1.jpg");
             setPixmap(pix.scaled(400, 400));
             break;
        }
        case Qt::MiddleButton :
        {
             QPixmap pix(":/Images/Images/PolarBearImage2.jpg");
             setPixmap(pix.scaled(400, 400));
             break;
        }
        case Qt::RightButton :
        {
             QPixmap pix(":/Images/Images/PolarBearImage3.jpg");
             setPixmap(pix.scaled(400, 400));
             break;
        }
        default :
            QLabel::mousePressEvent(event);
    }
}
