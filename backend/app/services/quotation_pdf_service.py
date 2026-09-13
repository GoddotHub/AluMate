import os
import platform
from reportlab.lib.pagesizes import letter
from reportlab.pdfgen import canvas
from reportlab.pdfbase.ttfonts import TTFont, TTFError
from reportlab.platypus import SimpleDocTemplate, Paragraph, Spacer
from reportlab.lib.styles import getSampleStyleSheet

if platform.system() == "Windows":
    FONT_PATH = "C:\\Windows\\Fonts\\segoeui.ttf"
else:
    FONT_PATH = "/data/data/com.termux/files/usr/share/fonts/TTF/DejaVuSans.ttf"

# Register Font safely
try:
    TTFont("DejaVuSans", FONT_PATH)
except Exception:
    pass

def generate_quotation_pdf(quotation_data, output_path="quotation.pdf"):
    doc = SimpleDocTemplate(output_path, pagesize=letter)
    story = []
    styles = getSampleStyleSheet()
    
    title_text = f"Quotation #{quotation_data.get('id', '1001')}"
    story.append(Paragraph(title_text, styles['Title']))
    story.append(Spacer(1, 12))
    
    doc.build(story)
    return output_path
